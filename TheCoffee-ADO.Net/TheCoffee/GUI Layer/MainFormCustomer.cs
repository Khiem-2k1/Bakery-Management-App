using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Beans;

namespace TheCoffee
{
    public partial class MainFormCustomer : Form
    {
        private User user { set; get; }
        public bool IsLogout { set; get; }
        public MainFormCustomer()
        {
            InitializeComponent();
            IsLogout = false;
            customizeDesing();
        }
        //truy?n vào tham sô là user
        // tr?ng thái login = false, ??t ordertable là 1 datatable m?i và truy?n các giá tr? c?n thi?t vào các c?t c?u ?dertable
        public MainFormCustomer(User user)
        {
            InitializeComponent();
            customizeDesing();
            this.user = user;
            IsLogout = false;
            this.user.orderTable = new DataTable();
            user.orderTable.Columns.Add("MaSP");
            user.orderTable.Columns.Add("TenSP");
            user.orderTable.Columns.Add("SoLuong");
            user.orderTable.Columns.Add("Gia");
        }
        //??t tr?ng thái visible c?a pnlsubmenuthongtin thành false
        private void customizeDesing()
        {
            pnlSubMenuThongTin.Visible = false;
        }
        //N?u pnlsubmenu ?ang hi?n th? gi?u nó ?i
        private void hideSubMenu()
        {
            if (pnlSubMenuThongTin.Visible == true)
                pnlSubMenuThongTin.Visible = false;
        }
        //Ng??c l?i v?i trên
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        //Th?c hi?n m? form con
        //N?u pnlView ko có form con thì thì t?o form con m?i và d?i nó lên phía trên
        //N?u ?ã có r?i thì ch? d?i nó lên phía trên
        private void openChildForm(UserControl childForm)
        {
            if (!pnlView.Controls.Contains(childForm))
            {
                pnlView.Controls.Add(childForm);
                childForm.Dock = DockStyle.Fill;
                childForm.BringToFront();
            }
            else
                childForm.BringToFront();

        }
        //G?i khi mainform c?a customer ???c load
        //Th?c hi?n thêm mainformview vào pnlView
        private void MainFormCustomer_Load(object sender, EventArgs e)
        {
            //pnlView.Controls.Add(new MainFormViewCNPM());
            openChildForm(new MainFormViewCNPM());
        }
        //G?i khi nh?n vào nút tìm ki?m
        //??t lebel tên pasge là tìm ki?m s?n ph?m
        //t?o 1 form con và hi?n th? d?a theo n?i dung nh?p vào
        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblNamePage.Text = "Tìm kiếm sản phẩm";
            timKiemSanPhamTheoTenView frm =  new timKiemSanPhamTheoTenView(txtSearch.Text, this.user);
            frm.themVaoGioHang = new timKiemSanPhamTheoTenView.ThemVaoGioHang(LoadGioHang);
            openChildForm(frm);
        }

        //n?u trong table ko có dòng thì s? thêm các các dòng t? order vào
        // n?u có r?i thì ki?m tra
        // n?u v? trí =-1 thì kiêm tri?p coi ma sp c?a t?ng l?n ch?y có = v?i productID c?a order ko? => vitri = s? th? t? l?n ch?y ko thì ti?p t?c ch?y
        // Sau ?ó ki?m tra coi v? trí có thay ??i ko? => n?u có thì thêm s? l??ng c?a dòng hi?n t?i vào s? l??ng c?a order, ko thì thêm các thu?c tính c?a order vào các dòng c?a order table
        //Cu?i cùng hi?n ra tên sp cùng s? l??ng
        private void LoadGioHang(Order order)
        {

            if (user.orderTable.Rows.Count == 0)
            {
                user.orderTable.Rows.Add(order.productID, order.productName, order.quantity, order.price);
            }
            else
            {
                int vitri = -1;
                for (int i = 0; i < user.orderTable.Rows.Count; i++)
                {
                    if (user.orderTable.Rows[i]["MaSP"].ToString() == order.productID.ToString())
                        vitri = i;
                }
                if (vitri != -1)
                {
                    int currQuantity = int.Parse(user.orderTable.Rows[vitri]["SoLuong"].ToString());
                    user.orderTable.Rows[vitri]["SoLuong"] = (currQuantity + order.quantity);

                }
                else
                {
                    user.orderTable.Rows.Add(order.productID, order.productName, order.quantity, order.price);
                }

            }
            Console.WriteLine(user.orderTable.Rows.Count);
            foreach(DataRow row in user.orderTable.Rows)
            {
                Console.WriteLine(row["TenSP"] + " " + row["SoLuong"] );
            }
            
        }
        //t?o 1 form con là form chinh
        private void btnHome_Click(object sender, EventArgs e)
        {
            lblNamePage.Text = "Home";
            openChildForm(new MainFormViewCNPM());
            
        }
        //Hi?n thông tin c?a pnl lên 
        private void btnThongTin_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlSubMenuThongTin);
        }
        //thì ??i mk thôi, gi?i thích hoài m?t quá
        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            lblNamePage.Text = "Đổi mật khẩu";
            openChildForm(new changePasswordView(user));
            hideSubMenu();
        }
        //T?o form con là view GioHang c?a user
        private void btnGioHang_Click(object sender, EventArgs e)
        {
            lblNamePage.Text = "Giỏ hàng";
            openChildForm(new GioHangView(user));

        }
        //nh?n vào thì t?o form m?i là view thông account c?u user và gi?u cái submenu ?i
        private void btnChinhSuaThongTin_Click(object sender, EventArgs e)
        {
            lblNamePage.Text = "Thông tin cá nhân";
            openChildForm(new inFoAccountView(user));
            hideSubMenu();
        }
        //T?o ra 1 form m?i là quan li ??n hàng c?a user
        private void btnQuanLiDonHang_Click(object sender, EventArgs e)
        {
            lblNamePage.Text = "Quản lí đơn hàng";
            openChildForm(new QuanliDonHangCaNhan(this.user));
        }
        //Out khoi tk hi?n t?i
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            IsLogout = true;
            this.Close();
        }

    }
}
