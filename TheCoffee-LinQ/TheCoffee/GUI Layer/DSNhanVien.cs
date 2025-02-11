using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Beans;
using System.Text.RegularExpressions;

namespace TheCoffee
{
    public partial class DSNhanVien : UserControl
    {
        private UserDAO db = new UserDAO();
        public DSNhanVien()
        {
            InitializeComponent();
        }
        //hàm này g?i t?i hàm load_data()
        private void DSNhanVien_Load(object sender, EventArgs e)
        {
            load_data();
        }
        //hàm này s? l?y b?ng toàn b? nhân viên vào dataGridView1
        //T?o 1 lít là ListRole có 2 n?i dung là admin và employee
        //listRole này s? ???c n?p data t? dataSource c?a cbbRole
        private void load_data()
        {
            TheCoffeDataContext coffe = new TheCoffeDataContext();
            var khQuery = (from nd in coffe.Users
                           where nd.us_role == "Employee"
                           || nd.us_role == "Admin"
                           select nd).ToList();
            dataGridView1.DataSource = khQuery;//L?y d? li?u khách hàng b?ng cách g?i hàm getAllKhachHang t? UerDAO
            //dataGridView1.DataSource = db.getAllNhanVien().Tables[0];
            List<String> listRole = new List<String>()
            {
                "Admin",
                "Employee"
            };
            cbbRole.DataSource = listRole;
        }
        //Event này s? ???c g?i khi nh?n vào nút capnhat
        //N?u kt không r?ng = true thì ??t gender và err = "", r?i sau ?ó
            //N?u check rdGenderMale = true thì gender = "M" , ng??c l?i thì "F"
            //N?u không th? c?p nh?t user thì s? hi?n ra thông báo l?i
        //N?u thành công thì s? hi?n ra thông báo thành công r?i load data và clear form
        //N?u kt
        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            if(IsValid()) //N?u kt không r?ng = true thì ??t gender và err = "", r?i sau ?ó
            {
                string gender = "";
                string err = "";
                if (rdGenderMale.Checked == true)//N?u check rdGenderMale = true thì gender = "M" , ng??c l?i thì "F"
                    gender = "M";
                else
                    gender = "F";
                //N?u không th? c?p nh?t user thì s? hi?n ra thông báo l?i
                if (!db.updateUser(ref err, txb_username.Text, txb_pass.Text, txb_firstname.Text, txb_lastname.Text, txb_address.Text, dt_birth.Value, gender, txb_phone.Text, txb_email.Text, cbbRole.SelectedValue.ToString()))
                    MessageBox.Show("Xảy ra lỗi khi cập nhật!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {  //N?u thành công thì s? hi?n ra thông báo thành công r?i load data và clear form
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load_data();
                    clear_frm();
                }
            }
            else//N?u kt r?ng = true thì hi?n thông báo yêu c?u c?p nh?t ??y ?? thông tin
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        //Event ???c g?i khi nh?n vào nút thêm
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if(IsValid())//N?u kt không r?ng = true thì ??t gender và err = "", r?i sau ?ó
            {
                string err = "";
                string gender = "";
                if (rdGenderMale.Checked == true)//N?u check rdGenderMale = true thì gender = "M" , ng??c l?i thì "F"
                    gender = "M";
                else
                    gender = "F";
                //N?u không th? thêm user thì s? hi?n ra thông báo l?i
                if (!db.insertUser(ref err, txb_username.Text, txb_pass.Text, txb_firstname.Text, txb_lastname.Text, txb_address.Text, dt_birth.Value, gender, txb_phone.Text, txb_email.Text, cbbRole.SelectedValue.ToString()))
                    MessageBox.Show("Xảy ra lỗi khi thêm nhân viên!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {//N?u thành công thì s? hi?n ra thông báo thành công r?i load data và clear form
                    MessageBox.Show("Đã thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load_data();
                    clear_frm();
                }
            }
            else//N?u kt r?ng = true thì hi?n thông báo yêu c?u c?p nh?t ??y ?? thông tin
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Goi t?i event này khi nh?n vào nút Xóa
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                string err = "";
                if (!db.delelteUser(ref err, txb_username.Text))//N?u không th? xóa user thì s? hi?n ra thông báo l?i
                    MessageBox.Show("Xảy ra lỗi khi xoá nhân viên!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else load_data();//Không thì s? load data và hi?n ra thông báo thành công
                MessageBox.Show("Đã xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException)
            {// N?u catch ???c l?i sql thì hi?n ra thông báo xóa th?t b?i
                MessageBox.Show("Xoá người dùng thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Hàm này dùng ?? load Userform s? d?ng tham s? username
        private void load_Userform(string username)
        {
            User1 user = db.getInfoUser(username);

            txb_username.Text = user.username;
            txb_firstname.Text = user.firstName;
            txb_lastname.Text = user.lastName;
            txb_address.Text = user.address;
            dt_birth.Text = user.birthday.ToString();
            txb_phone.Text = user.phone;
            txb_email.Text = user.email;
            txb_pass.Text = user.password;
            cbbRole.SelectedItem = user.role;
            if (user.gender == "M")
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
        //Event này ???c g?i khi ta nh?n vào dataGridView1_Cell1
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;//T?o bi?n r t? v? trí dòng c?a ô hi?n t?i
            load_Userform(dataGridView1.Rows[r].Cells[0].Value.ToString());//G?i hàm load user form v?i tham s? là giá tr? c?a ô(0) t?i hàng(r) c?a dataGridView1
            txb_pass.Enabled = false;//Ch?nh l?i thanh pass và comboboxRole =false
            cbbRole.Enabled = false;
        }
        //hàm này dùng ?? clear toàn b? d? li?u c?a form
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
        //Event này ???c g?i khi ta nh?n vào nút btn_clearfrm
        //Nó s? clear toàn b? form hi?n t?i
        private void btn_clearfrm_Click(object sender, EventArgs e)
        {
            clear_frm();
        }

        //Hàm này dùng ?? ki?m tra ch? s?
        //Nó s? t?o ra 1 regex v?i n?i dung c?n kiêm tra
        //tr? v? bool coi tham s? truy?n vào có trùng v?i n?i dung c?a regex không
        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0 - 9] *\.?[0 - 9] +$");
            return regex.IsMatch(pText);
        }

        //Ki?m tra coi n?i dung có b? r?ng không
        //N?u r?ng thì s? hi?n l?i v?i control t??ng ?ng và string là Required
        //N?u không r?ng thì s? hi?n string là ""
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
