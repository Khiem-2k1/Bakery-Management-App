using Beans;
using Business;
using System;
using System.Data;
using System.Windows.Forms;
using User = DBProvider.User;
namespace TheCoffee
{
    public partial class SignInForm : Form
    {
        private UserDAO db = new UserDAO();
        public User User { set; get; }
        public bool IsLogin { set; get; }
        public bool IsRegister { set; get; }

        public SignInForm()
        {
            InitializeComponent();
            IsLogin = false;
            User = new User();
        }

        // G?i khi nh?n vào nút login
        // Ki?m tra giá tr? nh?p vào có chính xác không?
        // Ki?m tra tr?ng thái c?a nó
        // N?u ?úng thì hi?n th? thông tin tài kho?n ra, không thì hi?n th? l?i
        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool status = db.CheckLogin(txtUsername.Text, txtPassword.Text);
            //int status = Convert.ToInt32(ds.Tables[0].Rows[0]["status"]);

            if (status)
            {
                IsLogin = true;
                User = db.GetInfoUser(txtUsername.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // G?i khi nh?n vào label5
        // Th?c hi?n vi?c thoát ra
        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // G?i khi nh?n vào nút password_key
        // Ki?m tra keychar có = 13 không => ??ng nh?p
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnLogin_Click(sender, e);
            }
        }

        // G?i khi nh?n vào nút X
        // Th?c hi?n thoát ra
        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // G?i khi nh?n vào linkRegister_Link
        // ??t IsRegister=true và ?óng l?i
        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IsRegister = true;
            this.Close();
        }
    }
}
