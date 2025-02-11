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

namespace TheCoffee
{
    
    public partial class inFoAccountView : UserControl
    {
        private UserDAO db = new UserDAO();
        private User1 user { set; get; }
        public inFoAccountView()
        {
            InitializeComponent();
        }
        public inFoAccountView(User1 user)
        {
            InitializeComponent();
            this.user = user ;
        }
        //Load data vào các controls t??ng ?ng
        private void load_Userform(User1 user)
        {
            user = db.getInfoUser(user.username);
            txb_firstname.Text = user.firstName;
            txb_lastname.Text = user.lastName;
            txb_address.Text = user.address;
            dt_birth.Text = user.birthday.ToString();
            txb_phone.Text = user.phone;
            txb_email.Text = user.email;
            lblRole.Text = user.role;
            if(user.gender == "M")
            {
                rdGenderMale.Checked = true;
                rdGenderFemale.Checked = false;
            } else
            {
                rdGenderMale.Checked = false;
                rdGenderFemale.Checked = true;
            }
            
        }
        //Load thoogn tin account này lên form
        private void inFoAccountView_Load(object sender, EventArgs e)
        {

            load_Userform(this.user);
        }
        //Load thoogn tin account này lên form

        private void btnReset_Click(object sender, EventArgs e)
        {
            load_Userform(this.user);
        }
        //Cap nhat thong tin 
        //Neu ko rong thi thuc hien viec cap nhat va thong bao thanh cong va load data lên
        //Neu that bai thi bao loi
        //Neu rong thi keu nhap l?i
        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            if(IsValid())
            {
                string gender = "";
                string err = "";
                if (rdGenderMale.Checked == true)
                    gender = "M";
                else if(rdGenderFemale.Checked == true)
                    gender = "F";

                if (!db.updateUser(ref err, this.user.username, this.user.password, txb_firstname.Text, txb_lastname.Text, txb_address.Text, dt_birth.Value, gender, txb_phone.Text, txb_email.Text, lblRole.Text))
                    MessageBox.Show("Xảy ra lỗi khi cập nhật thông tin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    this.user = db.getInfoUser(this.user.username);
                    MessageBox.Show("Đã cập nhật thông tin cá nhân", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load_Userform(this.user);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Ham kiem tra co r?ng hay ko
        bool IsValid()
        {
            bool check = true;
            if (String.IsNullOrEmpty(txb_firstname.Text))
            {
                check = false;
                errorProvider1.SetError(txb_firstname, "Required");
            }else
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
            }else
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
