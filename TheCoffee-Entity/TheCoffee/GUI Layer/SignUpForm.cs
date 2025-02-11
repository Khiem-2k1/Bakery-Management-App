using Business;
using System;
using System.Windows.Forms;

namespace TheCoffee
{
    public partial class SignUpForm : Form
    {
        private UserDAO userDAO;
        public bool IsLogin { set; get; }

        public SignUpForm()
        {
            InitializeComponent();
            userDAO = new UserDAO();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirm = txtConfirmPassword.Text;
            string err = "";

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password) && password.Equals(confirm))
            {
                if (userDAO.Register(ref err, username, password))
                {
                    MessageBox.Show("Register success!", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Username already exists!", "About", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please enter all correct information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IsLogin = true;
            this.Close();
        }
    }
}
