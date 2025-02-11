using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
//using Beans;
using DBProvider;

namespace TheCoffee
{
    public partial class changePasswordView : UserControl
    {
        private UserDAO db;
        private User user;
        private Beans.User user1;

        public changePasswordView()
        {
            InitializeComponent();
            db = new UserDAO();
        }

        public changePasswordView(User user)
        {
            InitializeComponent();
            db = new UserDAO();
            this.user = user;
        }

        public changePasswordView(Beans.User user1)
        {
            this.user1 = user1;
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                string err = "";
                bool success = db.ChangePassword(ref err, this.user.us_username, txtOldPassword.Text, txtNewPassword.Text, txtConfirmPassword.Text);

                if (success)
                {
                    MessageBox.Show("Password changed successfully.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Ham kiem tra
        // Ki?m tra xem các tr??ng nh?p li?u có b? tr?ng không, n?u có thì tr? v? false
        bool IsValid()
        {
            if (string.IsNullOrEmpty(txtOldPassword.Text) || string.IsNullOrEmpty(txtNewPassword.Text) || string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                return false;
            }

            return true;
        }
    }
}
