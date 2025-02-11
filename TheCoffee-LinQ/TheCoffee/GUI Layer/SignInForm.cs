using Beans;
using Business;
using System;
using System.Data;
using System.Windows.Forms;

namespace TheCoffee
{
    public partial class SignInForm : Form
    {
        private UserDAO db = new UserDAO();
        //private DataSet ds = new DataSet();
        public User1 user { set; get; }
        public bool IsLogin { set; get; }
        public bool IsRegister { set; get; }

        public SignInForm()
        {
            ///constructor
            InitializeComponent();
            IsLogin = false;
            user = new User1();
        }

        //G?i khi nh?n vào nút login
        //ki?m tra giá tr? nh?p vào có chính xác ko?
        //ki?m tra tr?ng thái c?a nó
        //N?u ?úng thì hi?n th? thông tin tài kho?n ra, ko thì hi?n l?i
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            //DataSet ds = db.checkLogin(txtUsername.Text, txtPassword.Text);            
            //int status = Convert.ToInt32(ds.Tables[0].Rows[0]["status"]);

            if (db.checkLogin(txtUsername.Text, txtPassword.Text))
            {
                IsLogin = true;
                user = db.getInfoUser(txtUsername.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tài khoản & mật khẩu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //G?i khi nh?n vào label5
        //Th?c hi?n vi?c thoát ra
        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //G?i khi nhân vào nút password_key
        //kiêm tra keychar có = 13 ko =>??ng nh?p
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnLogin_Click(sender, e);
            }
        }
        //G?i khi nh?n vào nút X
        //Th?c hi?n thoát ra
        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //G?i khi nh?n vào linkRegister_Link
        //??t isregister=true và ?óng l?i
        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IsRegister = true;
            this.Close();
        }
        //event r?ng
        
    }
}
