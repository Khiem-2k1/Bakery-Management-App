using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Beans;
using Business;

namespace TheCoffee
{
    public partial class GioHangView : UserControl
    {
        public TransactionDAO transactionDB = new TransactionDAO();
        public OrderDAO orderDB = new OrderDAO();
        public User1 user { set; get; }
        public GioHangView()
        {
            InitializeComponent();
        }
        public GioHangView(User1 user)
        {
            InitializeComponent();
            this.user = user;
        }
        //Load data vào các controls t??ng ?ng
        public void LoadData()
        {
            dgvGioHang.DataSource = user.orderTable;
            lblName.Text = user.firstName + "" + user.lastName;
            lblPhone.Text = user.phone;
            lblAddress.Text = user.address;
            lblEmail.Text = user.email;
            lblTotalPrice.Text = 0 + "VND";
            btnDatHang.Enabled = false;

        }
        //g?i hàm load và d?t selectedIndex cua ccbphuognthucthanhtoan=0
        private void GioHangView_Load(object sender, EventArgs e)
        {
            LoadData();
            ccbPhuongThucThanhToan.SelectedIndex = 0;
           
        }
        //N?u giá tr? masp c?a dgvGioHang dòng r == productID thì s? xóa dòng ?ó
        private void DeleteRow(int r)
        {
            int productID = Convert.ToInt32(dgvGioHang.Rows[r].Cells["MaSP"].Value);
            for(int i = 0; i < user.orderTable.Rows.Count; i++)
            {
                if(Convert.ToInt32(user.orderTable.Rows[i]["MaSP"]) == productID)
                {
                    user.orderTable.Rows[i].Delete();
                }
            }
        }
        //Ki?m tra ??n hàng có r?ng hay ko
        private void checkDonHangRong(bool check)
        {
            if (check)
            {
                btnDatHang.Enabled = true;
                lblLuuY.Visible = false;

            }
            else
            {
                btnDatHang.Enabled = false;
                lblLuuY.Visible = true;
            }
        }

        //G?i khi nh?n vào nút dgvGioHang_CellContent
        //??t command = giá tr? c?a tên c?t th? e.columnindex dgvGioHang
        //N?u giá tr? = "delete" thì xóa dòng ?ó
        private void dgvGioHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvGioHang.CommitEdit(DataGridViewDataErrorContexts.Commit);
            string command = dgvGioHang.Columns[e.ColumnIndex].Name;
            if(command == "Delete")
            {
                int r = dgvGioHang.CurrentCell.RowIndex;
                DeleteRow(r);
            }
        }

        //G?i khi giá tr? ô dgvGioHang b? thay ??i
        //T?o 1 vòng l?p và m?i l?n ch?y s? ki?m tra coi giá tr? ki?u bool c?a ô selected có = true ko?
        //N?u b?ng thì check =true và t?ng ti?n d?a theo giá tr? c?a ô Gia
        //K?t thúc b?ng cách check don hang co rong hay ko và in ra gia tien
        private void dgvGioHang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            double totalPrice = 0;
            bool check = false;
            for (int i = 0; i < dgvGioHang.Rows.Count; i++)
            {
                DataGridViewRow row = dgvGioHang.Rows[i];
                if(Convert.ToBoolean(row.Cells["Selected"].Value) == true)
                {
                    check = true;
                    totalPrice += Convert.ToDouble(row.Cells["Gia"].Value);
                }
            }
            lblTotalPrice.Text = totalPrice.ToString() + "VND";
            checkDonHangRong(check);
            Console.WriteLine(totalPrice);

            
        }
        //Goi khi nhan vao nur DatHang
        //chèn n?i dung transaction vào db
        //T?o vòng l?p kiêm tra giá tr? ô selected
        //Neu ?úngt hì ??t hàng và xóa cái dòng ?ó và in thông báo thành công
        //khoogn thì báo l?i
        private void btnDatHang_Click(object sender, EventArgs e)
        {
            string err = "";
            DateTime dateNow = DateTime.Now;

            try
            {
                transactionDB.insertTransaction(ref err, user.username, user.address, user.phone, dateNow, txtNote.Text);
                int transactionID = transactionDB.getTransactionID();
                Console.WriteLine(transactionID);
                for(int i = dgvGioHang.Rows.Count - 1; i >= 0 ; i--)
                {
                    DataGridViewRow row = dgvGioHang.Rows[i];
                    if(Convert.ToBoolean(row.Cells["Selected"].Value) == true)
                    {
                        Order1 order = new Order1();
                        order.username = user.username;
                        order.transactionID = transactionID;
                        order.productID = Convert.ToInt32(row.Cells["MaSP"].Value);
                        order.quantity = Convert.ToInt32(row.Cells["SoLuong"].Value);
                        orderDB.insertOrder(ref err, order);
                        DeleteRow(i);
                        
                    }
                }
                MessageBox.Show("Đặt hàng thành công!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(SqlException)
            {
                MessageBox.Show("Xảy ra lỗi trong đặt hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }
        //Thuc hi?n ??i ph??ng th?c thanh toán b?ng cách ch?nh visible c?a pnlATM d?a theo giá tr? index c?a ccbPhuognTHucThanhToan
        private void ccbPhuongThucThanhToan_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ccbPhuongThucThanhToan.SelectedIndex;
            if(index == 1)
            {
                pnlATM.Visible = true;
            }
            else
            {
                pnlATM.Visible = false;
            }
        }
    }
}
