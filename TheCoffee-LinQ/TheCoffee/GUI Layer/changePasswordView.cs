using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Beans;
using Business;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TheCoffee
{
    public partial class changePasswordView : UserControl
    {
        UserDAO db = new UserDAO(); 
        private User1 user { set; get; } 

        public changePasswordView()
        {
            InitializeComponent();
        }

        public changePasswordView(User1 user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e) //khi ta nhan vao nut doi mk se goi toi event nay
        {
            if(IsValid()) //N?u hàm ki?m tra tr? v? true
            {
                string err = "";//tao bien err ki?u string
                bool ds = db.changePassword(ref err, this.user.username, txtOldPassword.Text, txtNewPassword.Text, txtConfirmPassword.Text); //t?o bi?n ds ki?u DataSet = cách g?i t?i hàm changePassword t? UserDAO
                if(ds)
                {
                    MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);//Hi?n h?p thông báo v?i tiêu ?? thông báo và nút OK
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);//Hi?n h?p thông báo v?i tiêu ?? thông báo và nút OK
                }
            } 
            else //N?u hàm ki?m tra tr? v? false thì hi?n ra thông báo vui lòng ??ng nh?p ??y ?? thông tin
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
            }

        }

        //Ham kiem tra
        //Ki?m tra coi n?i dung nh?p vào trong các thanh là có b? r?ng không, n?u có thì tr? l?i v? control t??ng ?ng v?i string là Required, còn n?u có n?i dung thì tr? l?i v?i string là "" (r?ng)
        //tra ve check
        bool IsValid() 
        {
            bool check = true; 
            if (String.IsNullOrEmpty(txtOldPassword.Text)) 
            {
                check = false;
                errorProvider1.SetError(txtOldPassword, "Required");
            }
            else
            {
                errorProvider1.SetError(txtOldPassword, "");
            }

            if (String.IsNullOrEmpty(txtNewPassword.Text))
            {
                check = false;
                errorProvider1.SetError(txtNewPassword, "Required");
            }
            else
            {
                errorProvider1.SetError(txtNewPassword, "");
            }
            if (String.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                check = false;
                errorProvider1.SetError(txtConfirmPassword, "Required");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, "");
            }
            return check;            
        }
    }
    
}
