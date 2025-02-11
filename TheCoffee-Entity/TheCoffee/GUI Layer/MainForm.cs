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
//using Beans;
using DBProvider;
using TheCoffee.GUI_Layer;

namespace TheCoffee
{
    public partial class MainForm : Form
    {
        private User user { set; get; }
        public bool IsLogout { set; get; }

        public MainForm()
        {
            InitializeComponent();
            IsLogout = false;
           
        }
        //user truy?n vào s? b?ng usser hi?n t?i và ch?nh tr?ng thái logout = false và g?i hàm customizeDesing()
        public MainForm(User user)
        {
            InitializeComponent();
            this.user = user;
            IsLogout = false;
            customizeDesing();
        }

        //t?t 2 pnl thong tin v danh muc
        private void customizeDesing()
        {
            pnlSubMenuThongTin.Visible = false;
            pnlSubMenuDanhMuc.Visible = false;
        }
        //d?u submenu n?u ?ang hi?n
        private void hideSubMenu()
        {
            if(pnlSubMenuThongTin.Visible == true)
                pnlSubMenuThongTin.Visible = false;
            if (pnlSubMenuDanhMuc.Visible == true)
                pnlSubMenuDanhMuc.Visible = false;
        }
        //Gi?ng tren nh?ng ng??c l?i
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
        //M? form con
        //n?u panel hi?n t?i ch?a có form con thì t?o form m?i và mang nó lên phía trc form hi?n t?i
        //n?u có r?i thì mang lên phía tren
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
        //load mainform
        //T?o form con m?i là view c?a mainform
        //n?u role ko là admin thì btnNhanVien ko ?c enable
        private void MainForm_Load(object sender, EventArgs e)
        {
            openChildForm(new MainFormViewCNPM());
            if (user.us_role != "Admin")
                btnNhanVien.Enabled = false;

        }
        //Hi?n thoogn tin
        private void btnThongTin_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlSubMenuThongTin);
        }
        //Hi?n danh muc
        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlSubMenuDanhMuc);
        }
        //T?o form m?i là view thong tin tk
        //và ?áu submenu ?i
        private void btnChinhSuaThongTin_Click(object sender, EventArgs e)
        {
            lblNamePage.Text = "Thông tin cá nhân";
            openChildForm(new inFoAccountView(this.user));
            hideSubMenu();
        }
        //Gi?ng trên nh?ng là ??i mk
        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            lblNamePage.Text = "Đổi mật khẩu ";
            openChildForm(new changePasswordView(this.user));
            hideSubMenu();
        }
        //Gi?ng trên nh?ng hi?n danh muc khac hanh
        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            lblNamePage.Text = "Danh mục khách hàng";
            openChildForm(new DSUser());
            hideSubMenu();
        }
        //Gi?ng trên nh?ng hiên ra danh muc san pham
        private void btnSanPham_Click(object sender, EventArgs e)
        {
            lblNamePage.Text = "Danh mục sản phẩm";
            openChildForm(new DSProduct());
            hideSubMenu();
        }
        //Gi?ng trên nh?ng hiên ra ds nhan vien
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            lblNamePage.Text = "Danh m?c nhân viên";
            openChildForm(new DSNhanVien());
            hideSubMenu();
        }
        //Gi?ng trên nh?ng hiên ra doanh thu
        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            lblNamePage.Text = "Doanh thu";
            openChildForm(new ThongKeBaoCaoView());
            hideSubMenu();
        }
        //out tk
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            IsLogout = true;
            this.Close();
        }
        //quay v? main form
        private void btnHome_Click(object sender, EventArgs e)
        {
            lblNamePage.Text = "Home";
            openChildForm(new MainFormViewCNPM());
        }

        private void baocao_Click(object sender, EventArgs e)
        {
            lblNamePage.Text = "Báo cáo đơn đặt hàng";
            openChildForm(new ReportOrder());
        }
    }
}
