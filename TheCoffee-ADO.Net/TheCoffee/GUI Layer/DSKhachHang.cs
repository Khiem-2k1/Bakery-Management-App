using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Beans;
using System.Text.RegularExpressions;

namespace TheCoffee
{
    public partial class DSUser : UserControl
    {
        private UserDAO db = new UserDAO();
       

        public DSUser()
        {
            InitializeComponent();
        }
        private void User_Load(object sender, EventArgs e)
        {
            load_data();
        }
        private void load_data()
        {
            dataGridView1.DataSource = db.getAllKhachHang().Tables[0];//L?y d? li?u khách hàng b?ng cách g?i hàm getAllKhachHang t? UerDAO
            List<String> listRole = new List<String>()//Tao list tên listrole và l?u datasource vào ?ó
            {
                "Customer"
            };
            cbbRole.DataSource = listRole;
        }

        //Event ???c g?i khi nh?n vào nút c?p nh?t
        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            if (IsValid()) 
            {
                string gender;
                string err = "";
                if (rdGenderMale.Checked == true)//kt coi rdGenderMale ???c check hay không , n?u check thì gender=M ng??c l?i gender=F
                    gender = "M";
                else
                    gender = "F";

                //N?u không th? g?i t?i hàm updateUser thì s? hi?n ra thông báo l?i
                if (!db.updateUser(ref err, txb_username.Text, txb_pass.Text, txb_firstname.Text, txb_lastname.Text, txb_address.Text, dt_birth.Value, gender, txb_phone.Text, txb_email.Text, cbbRole.SelectedValue.ToString()))
                    MessageBox.Show("Xảy ra lỗi khi cập nhật!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else//N?u thành công thì hi?n thông báo thành công, g?i hàm load data và clearform
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load_data();
                    clear_frm();
                }
            } else //Tr??ng h?p còn l?i s? hi?n ra thông báo yêu c?u ?i?n ??y ?? thông tin
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        
            
        }

        //G?i ??n event này khi nh?n vào btn_Them
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                string err = "";
                string gender;
                if (rdGenderMale.Checked == true)//N?u check vào rdGenderMale thì gender=M, không thì gender=F
                    gender = "M";
                else
                    gender = "F";

                //N?u không th? g?i t?i hàm insertUser thì hi?n ra thông báo l?i còn n?u thành công thì
                //hi?n ra thông báo thành công và g?i ??n hàm loaddata() và clear_frm()
                //còn không thì hi?n ra thông báo yêu c?u ?i?n ??y ?? thông tin
                if (!db.insertUser(ref err, txb_username.Text, txb_pass.Text, txb_firstname.Text, txb_lastname.Text, txb_address.Text, dt_birth.Value, gender, txb_phone.Text, txb_email.Text, cbbRole.SelectedValue.ToString()))
                    MessageBox.Show("Xảy ra lỗi khi thêm khách hàng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Đã thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load_data();
                    clear_frm();
                }
            }else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }  
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                string err = "";
                //N?u không th? g?i t?i hàm delelteUser thì hi?n ra thông báo x?y ra l?i còn n?u thành công thì
                //hi?n ra thông báo thành công và g?i ??n hàm loaddata()
                //còn n?u g?p l?i thì hi?n ra thông báo th?t b?i

                if (!db.delelteUser(ref err, txb_username.Text))
                    MessageBox.Show("Xảy ra lỗi khi xoá khách hàng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    load_data();
                MessageBox.Show("Đã xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } 
            } catch(Exception)
            {
                MessageBox.Show("Xoá khách hàng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
          

        }

        //Ham load form user s? d?ng tham s? username
        private void load_Userform(string username)
        {
            User user = db.getInfoUser(username);//T?o obj user = cách l?y thông tin user t? tham s? username

            txb_username.Text = user.username;
            txb_firstname.Text = user.firstName;
            txb_lastname.Text = user.lastName;
            txb_address.Text = user.address;
            dt_birth.Text = user.birthday.ToString();
            txb_phone.Text = user.phone;
            txb_email.Text = user.email;
            txb_pass.Text = user.password;
            cbbRole.SelectedItem = user.role;
            if (user.gender == "M")//N?u gender =M thì check rdGenderMale = true và check rdGenderFemale = false, còn ng??c l?i thì check ng??c l?i
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

        //???c g?i khi nh?n vào dataGridView1_Cell
        //Load userform theo v? trí dòng c?a ô hi?n t?i và ??t txb_pass và cbbRole = false
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex; //T?o bi?n r = l?y v? trí dòng c?a ô hi?n t?i t? dataGridView1
            load_Userform(dataGridView1.Rows[r].Cells[0].Value.ToString());
            txb_pass.Enabled = false;
            cbbRole.Enabled = false;
            
            
        }
        //Hàm này dùng ?? clear toàn b? nooij dung trong form
        private void clear_frm()
        {
            txb_pass.Enabled = true;
            cbbRole.Enabled = true;

            txb_username.Clear();
            txb_firstname.Clear();
            txb_lastname.Clear();
            txb_address.Clear();
            rdGenderMale.Checked = true;
            rdGenderFemale.Checked = false;
            txb_phone.Clear();
            txb_email.Clear();
            txb_pass.Clear();

        }
        //G?i t?i event này khi ta nh?n nút clear
        //Event này s? g?i ??n hàm clear_frm();
        private void btn_clearfrm_Click(object sender, EventArgs e)
        {
            clear_frm();
        }
        //Ki?m tra có s? không
        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0 - 9] *\.?[0 - 9] +$");//T?o regex có n?i dung nh? sau
            return regex.IsMatch(pText);//Ki?m tra coi tham s? truy?n vào có trùng v?i n?i dung trên không
        }

        //Ki?m tra n?i dung trên các controls có r?ng không
        //N?u r?ng thì báo l?i v?i control t??ng ?ng v?i string là "Required"
        //N?u không r?ng thì báo l?i v?i string là ""
        bool IsValid()
        {
            bool check = true;
            if (String.IsNullOrEmpty(txb_username.Text))
            {
                check = false;
                errorProvider1.SetError(txb_username, "Required");
            }
            else
            {
                errorProvider1.SetError(txb_username, "");
            }

            if (String.IsNullOrEmpty(txb_pass.Text))
            {
                check = false;
                errorProvider1.SetError(txb_pass, "Required");
            }
            else
            {
                errorProvider1.SetError(txb_pass, "");
            }

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

            if (String.IsNullOrEmpty(txb_phone.Text) && IsNumber(txb_phone.Text))
            {
                check = false;
                errorProvider1.SetError(txb_phone, "Required and need a number phone");
            }
            else
            {
                errorProvider1.SetError(txb_phone, "");
            }

            return check;
        }


    }
}
