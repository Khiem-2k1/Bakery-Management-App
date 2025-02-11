using Business;
using System;
using System.Windows.Forms;

namespace TheCoffee
{
    public partial class SignUpForm : Form
    {
        public UserDAO userDAO = new UserDAO();
        public bool IsLogin { set; get; }
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirm = txtConfirmPassword.Text;
            string err = "";
            //??u tiên ki?m coi tk và mk có r?ng ko?
            //N?u r?ng thì hi?n l?i ko thì ti?p t?c kt
            //N?u ?ã t?n t?i thì hi?n l?i
            //khoogn thì thông báo ?k thành công
            if (username != null && username != "" && password != null & password != "" && password == confirm)
            {
                if (!userDAO.Register(ref err, username, password, confirm))
                {
                    MessageBox.Show("Username was exist!", "About", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Register success!", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Please enter all correct information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        //Khi nh?n nút X s? t?t 
        private void X_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }
        //Khi nh?n s? ch?nh tr?ng thái login sang true và ?óng cái này l?i
        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IsLogin = true;
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
