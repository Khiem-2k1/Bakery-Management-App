using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Business;
using User = DBProvider.User;
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

        private void DSNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dataGridView1.DataSource = db.GetAllNhanVien();
            List<String> listRole = new List<String>()
            {
                "Admin",
                "Employee"
            };
            cbbRole.DataSource = listRole;
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                string gender;
                string err = "";
                if (rdGenderMale.Checked == true)
                    gender = "M";
                else
                    gender = "F";

                if (!db.UpdateUser(ref err, txb_username.Text, txb_pass.Text, new User
                {
                    us_username = txb_username.Text,
                    us_password = txb_pass.Text,
                    us_firstname = txb_firstname.Text,
                    us_lastname = txb_lastname.Text,
                    us_address = txb_address.Text,
                    us_birthday = dt_birth.Value,
                    us_phone = txb_phone.Text,
                    us_email = txb_email.Text,
                    us_role = cbbRole.SelectedValue.ToString(),
                    us_gender = gender
                }))
                {
                    MessageBox.Show("Xảy ra lỗi khi cập nhật!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearForm();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                string err = "";
                string gender;
                if (rdGenderMale.Checked == true)
                    gender = "M";
                else
                    gender = "F"; 

                if (!db.InsertUser(ref err, txb_username.Text, txb_pass.Text, txb_firstname.Text, txb_lastname.Text, txb_address.Text, dt_birth.Value, gender, txb_phone.Text, txb_email.Text, cbbRole.SelectedValue.ToString()))
                {
                    MessageBox.Show("Xảy ra lỗi khi thêm nhân viên!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Đã thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearForm();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                string err = "";
                if (!db.DeleteUser(ref err, txb_username.Text))
                {
                    MessageBox.Show("Xảy ra lỗi khi xoá nhân viên!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    LoadData();
                    MessageBox.Show("Đã xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xoá nhân viên thât bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            LoadUserForm(dataGridView1.Rows[r].Cells[0].Value.ToString());
            txb_pass.Enabled = false;
            cbbRole.Enabled = false;
        }

        private void LoadUserForm(string username)
        {
            User user = db.GetInfoUser(username);

            txb_username.Text = user.us_username;
            txb_firstname.Text = user.us_firstname;
            txb_lastname.Text = user.us_lastname;
            txb_address.Text = user.us_address;
            dt_birth.Value = user.us_birthday;
            txb_phone.Text = user.us_phone;
            txb_email.Text = user.us_email;
            txb_pass.Text = user.us_password;
            cbbRole.SelectedItem = user.us_role;
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

        private void ClearForm()
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

        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(pText);
        }

        bool IsValid()
        {
            bool check = true;
            if (string.IsNullOrEmpty(txb_username.Text))
            {
                check = false;
                errorProvider1.SetError(txb_username, "Required");
            }
            else
            {
                errorProvider1.SetError(txb_username, "");
            }

            if (string.IsNullOrEmpty(txb_pass.Text))
            {
                check = false;
                errorProvider1.SetError(txb_pass, "Required");
            }
            else
            {
                errorProvider1.SetError(txb_pass, "");
            }

            if (string.IsNullOrEmpty(txb_firstname.Text))
            {
                check = false;
                errorProvider1.SetError(txb_firstname, "Required");
            }
            else
            {
                errorProvider1.SetError(txb_firstname, "");
            }

            if (string.IsNullOrEmpty(txb_lastname.Text))
            {
                check = false;
                errorProvider1.SetError(txb_lastname, "Required");
            }
            else
            {
                errorProvider1.SetError(txb_lastname, "");
            }

            if (string.IsNullOrEmpty(txb_address.Text))
            {
                check = false;
                errorProvider1.SetError(txb_address, "Required");
            }
            else
            {
                errorProvider1.SetError(txb_address, "");
            }

            if (string.IsNullOrEmpty(txb_email.Text))
            {
                check = false;
                errorProvider1.SetError(txb_email, "Required");
            }
            else
            {
                errorProvider1.SetError(txb_email, "");
            }

            if (string.IsNullOrEmpty(txb_phone.Text) || !IsNumber(txb_phone.Text))
            {
                check = false;
                errorProvider1.SetError(txb_phone, "Required and must be a valid phone number");
            }
            else
            {
                errorProvider1.SetError(txb_phone, "");
            }

            return check;
        }

        private void btn_clearfrm_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
