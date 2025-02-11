using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Beans;
using ModelCategories;

namespace TheCoffee
{
    public partial class QuanliDonHangCaNhan : UserControl
    {
        public User1 user { set; get; }
        public TransactionDAO transactionDAO = new TransactionDAO();
        public OrderDAO orderDAO = new OrderDAO();
        public QuanliDonHangCaNhan()
        {
            InitializeComponent();
        }
        public QuanliDonHangCaNhan(User1 user)
        {
            this.user = user;
            InitializeComponent();
        }
        //Ch?nh l?i tr?ng thái c?a 2 rd và g?i t?i hàm click c?a btnOk

        private void QuanliDonHangCaNhan_Load(object sender, EventArgs e)
        {
            rdAll.Checked = true;
            rdDate.Checked = false;
            btnOK_Click(sender, e);
        }
        //Ki?m tra coi check
        //N?u true thì truy?n thông tin user nh?p vào vào datasource c?a dgvTransaction
        //false thì truy?n thông tin user theo th?i gian vào datasource c?a dgvTransaction
        //R?i sau ?ó in ra t?ng ti?n
        private void btnOK_Click(object sender, EventArgs e)
        {
            bool check = rdAll.Checked;
            double tong = 0;
            TheCoffeDataContext coffe = new TheCoffeDataContext();
            
            if (check == true)
            {
                var tQuery = (from t in coffe.Transactions
                              where t.us_username == user.username
                              select new
                              {
                                  t.id,
                                  t.addressTo,
                                  t.phoneTo,
                                  t.totalprice,
                                  t.createdate,
                                  t.note
                              }).ToList();
                dgvDSTransaction.DataSource = tQuery;
                //dgvDSTransaction.DataSource = transactionDAO.getTransactionByUser(user.username).Tables[0];
            }
            else
            {
                var tQuery = (from t in coffe.Transactions
                              where t.us_username == user.username
                              && t.createdate >= dateFrom.Value
                              && t.createdate <= dateTo.Value
                              select t).ToList();
                dgvDSTransaction.DataSource = tQuery;
                //dgvDSTransaction.DataSource = transactionDAO.getTransactionByUserForDate(user.username, dateFrom.Text, dateTo.Text).Tables[0];
            }
            lblTongDon.Text = dgvDSTransaction.Rows.Count.ToString();
            foreach(DataGridViewRow row in dgvDSTransaction.Rows)
            {
                tong += Convert.ToDouble(row.Cells["TotalPrice"].Value);
            }
            lblTongTien.Text = tong + "VND";
        }

        //l?y giá tr? c?a id c?a ô hi?n t?i và truyên nó vào transactionID
        //r?i sau ?ó g?i hàm getodrdetail r?i truy?n thông tin l?y ???c vào datasource c?u dgvorderdetail
        private void dgvDSTransaction_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvDSTransaction.CurrentCell.RowIndex;
            int transactionID1 =Convert.ToInt32(dgvDSTransaction.Rows[r].Cells["ID"].Value);
            
            TheCoffeDataContext coffe = new TheCoffeDataContext();
            var View_DanhSachHangDaDats =
                               (from u in coffe.Users
                                from o in coffe.Orders
                                from p in coffe.Products
                                from t in coffe.Transactions
                                where u.us_username == o.us_username
                                && o.productID == p.id
                                && o.transactionID == transactionID1
                                select new
                                {
                                    u.us_username,
                                    transactionID = t.id,
                                    orderID = o.id,
                                    p.pro_name,
                                    o.or_quantity,
                                    o.or_price
                                }); 
            var voQueryDate = (from vo in View_DanhSachHangDaDats
                               where vo.us_username == user.username
                               && vo.transactionID == transactionID1
                               select new
                               {
                                   vo.orderID,
                                   vo.pro_name,
                                   vo.or_quantity,
                                   vo.or_price
                               }).ToList();
            dgvOrderDetail.DataSource = voQueryDate;
            //dgvOrderDetail.DataSource = orderDAO.getOrderDetail(user.username, transactionID).Tables[0];
        }
        //Goi khi nh?n vòa nút xoa
        //Thuc hien viec xoa ??n hàng  d?a vào giá tr? ID c?a ô hi?n t?i
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string err = "";
            try
            {
                int r = dgvDSTransaction.CurrentCell.RowIndex;
                int transactionID = Convert.ToInt32(dgvDSTransaction.Rows[r].Cells["ID"].Value);
                transactionDAO.deleteTransaction(ref err, transactionID);
                btnOK_Click(sender, e);
                
                MessageBox.Show("Xoá đơn hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(SqlException)
            {
                MessageBox.Show("Xảy ra lỗi không thể xóa đơn hàng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
