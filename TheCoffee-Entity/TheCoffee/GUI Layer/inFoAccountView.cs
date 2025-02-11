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
using Beans;
using User = DBProvider.User;
using DBProvider;

namespace TheCoffee
{
    public partial class inFoAccountView : UserControl
    {
        private UserDAO db = new UserDAO();
        private Beans.User user1;

        public User User { set; get; }

        public inFoAccountView()
        {
            InitializeComponent();
        }

        public inFoAccountView(User user)
        {
            InitializeComponent();
            User = user;
        }

        public inFoAccountView(Beans.User user1)
        {
            this.user1 = user1;
        }

        // Load data vào các controls t??ng ?ng
        private void load_Userform(User user)
        {
            user = db.GetInfoUser(user.us_username);
            txb_firstname.Text = user.us_firstname;
            txb_lastname.Text = user.us_lastname;
            txb_address.Text = user.us_address;
            dt_birth.Text = user.us_birthday.ToString();
            txb_phone.Text = user.us_phone;
            txb_email.Text = user.us_email;
            lblRole.Text = user.us_role;
            if (user.us_gender == "M")
            {
                rdGenderMale.Checked = true;
                rdGenderFemale.Checked = false;
            }
            else
            {
                rdGenderMale.Checked = false;
                rdGenderFemale.Checked = true;
            }
        }

        // Load thông tin account này lên form
        private void inFoAccountView_Load(object sender, EventArgs e)
        {
            load_Userform(User);
        }

        // Load thông tin account này lên form
        private void btnReset_Click(object sender, EventArgs e)
        {
            load_Userform(User);
        }

        // C?p nh?t thông tin
        // N?u không r?ng thì th?c hi?n vi?c c?p nh?t và thông báo thành công và load data lên
        // N?u th?t b?i thì báo l?i
        // N?u r?ng thì kêu nh?p l?i
        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                if (rdGenderMale.Checked == true)
                    User.us_gender = "M";
                else if (rdGenderFemale.Checked == true)
                    User.us_gender = "F";
                User.us_firstname = txb_firstname.Text;
                User.us_lastname = txb_lastname.Text;
                User.us_address = txb_address.Text;
                User.us_birthday = dt_birth.Value;
                User.us_email = txb_email.Text;
                
                string err = "";

                if (!db.UpdateUser(ref err, User.us_username, User.us_password, User))
                    MessageBox.Show("Xảy ra lỗi khi cập nhật thông tin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    User = db.GetInfoUser(User.us_username);
                    MessageBox.Show("Đã cập nhật thông tin cá nhân", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load_Userform(User);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Hàm ki?m tra có r?ng hay không
        bool IsValid()
        {
            bool check = true;
            if (String.IsNullOrEmpty(txb_firstname.Text))
            {
                check = false;
                errorProvider1.SetError(txb_firstname, "Required");
            }
            else
            {
                errorProvider1.SetError(txb_firstname, "");
            }

            if (String.IsNullOrEmpty(txb_lastname.Text))
            {
                check = false;
                errorProvider1.SetError(txb_lastname, "Required");
            }
            else
            {
                errorProvider1.SetError(txb_lastname, "");
            }


            if (String.IsNullOrEmpty(txb_address.Text))
            {
                check = false;
                errorProvider1.SetError(txb_address, "Required");
            }
            else
            {
                errorProvider1.SetError(txb_address, "");
            }

            if (String.IsNullOrEmpty(txb_email.Text))
            {
                check = false;
                errorProvider1.SetError(txb_email, "Required");
            }
            else
            {
                errorProvider1.SetError(txb_email, "");
            }

            if (String.IsNullOrEmpty(txb_phone.Text))
            {
                check = false;
                errorProvider1.SetError(txb_phone, "Required");
            }
            else
            {
                errorProvider1.SetError(txb_phone, "");
            }

            return check;
        }
    }
}
