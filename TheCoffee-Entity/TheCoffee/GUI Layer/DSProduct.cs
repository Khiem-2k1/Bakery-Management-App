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
using System.Text.RegularExpressions;
using DBProvider;

namespace TheCoffee
{
    public partial class DSProduct : UserControl
    {
        ProductDAO dbProduct = new ProductDAO();
        CategoriesDAO dbCategories = new CategoriesDAO();
        SupplierDAO dbSupplier = new SupplierDAO();
        public DSProduct()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            dgvProduct.DataSource = dbProduct.getAllProduct();//L?y toàn b? d? li?u product d??i d?ng b?ng và l?u vào ?ây
            // l?y t?t c? tên DANH M?C và ID b?ng query d??i d?ng b?ng vào dbCategories
            ccbCategories.DataSource = dbCategories.getAllNameCategories();
            //Sau ?ó ta gán các giá tr? vào các thu?c tính t??ng ?ng
            ccbCategories.DisplayMember = "cate_name";
            ccbCategories.ValueMember = "id";
            //l?y ID và Tên nhà cung c?p d??i d?ng b?ng vào ccbSuplier r?i gán giá tr? vào các thu?c tính t??ng ?ng
            ccbSupplier.DataSource = dbSupplier.GetAllNameSupplier();
            ccbSupplier.DisplayMember = "sup_name";
            ccbSupplier.ValueMember = "id";
        }
        //Event này ???c kích ho?t khi load DSProduct và nó g?i t?i hàm LoadData() ? trên
        private void DSProduct_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        //Event này ???c g?i khi ta nh?n vào nút dgvProduct_Cell
        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvProduct.CurrentCell.RowIndex;
            LoadProductForm(Convert.ToInt32(dgvProduct.Rows[r].Cells[0].Value));

            
            Console.WriteLine(ccbCategories.SelectedValue + " " + ccbSupplier.SelectedValue);
        }
        private void LoadProductForm(int id)
        {
            Product product = dbProduct.getProduct(id);
            

            txb_proname.Text = product.pro_name;
            txb_nhap.Text = product.pro_firstprice.ToString();
            txb_giaban.Text = product.pro_price.ToString();
            txb_SL.Text = product.pro_quantity.ToString();
            ccbSupplier.Text = product.supplierID.ToString();
            ccbCategories.Text = product.categoriesID.ToString();
            txb_des.Text = product.pro_description;
            dtpickerNSX.Value = product.pro_nsx;
            dtpickerHSD.Value=product.pro_hsd;
            
        }
        //Kh?i t?o khi nh?n vào nút buttonAdd
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string err = "";
            if(IsValid())
            {
                if(!dbProduct.insertProduct(ref err,Convert.ToInt32(ccbSupplier.SelectedValue), Convert.ToInt32(ccbCategories.SelectedValue), txb_proname.Text, Convert.ToInt32(txb_SL.Text), Convert.ToDouble(txb_nhap.Text),
                                Convert.ToDouble(txb_giaban.Text), txb_des.Text, dtpickerNSX.Value, dtpickerHSD.Value))
                    MessageBox.Show("Xảy ra lỗi khi thêm sản phẩm!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                { 
                    MessageBox.Show("Thêm sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            } else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            string err = "";
            if(IsValid())//N?u ko r?ng thì ch?y nh? sau
            {
                int r = dgvProduct.CurrentCell.RowIndex;
                if (!dbProduct.updateProduct(ref err, Convert.ToInt32(dgvProduct.Rows[r].Cells["ID"].Value),//N?u c?p nh?t product v?i tham s? chi?u t?i err,giá tr? ki?u int c?a dgvProduct ? dòng r, ô "pro_id";
                    Convert.ToInt32(ccbSupplier.SelectedValue), Convert.ToInt32(ccbCategories.SelectedValue),// giá tr? ki?u int c?a combobox category và supplier,txb product và txb_nhap ki?u double,... th?t b?i
                    txb_proname.Text, Convert.ToInt32(txb_SL.Text), Convert.ToDouble(txb_nhap.Text),//Thì hi?n ra thông báo l?i
                    Convert.ToDouble(txb_giaban.Text), txb_des.Text, dtpickerNSX.Value, dtpickerHSD.Value))
                    MessageBox.Show("Xảy ra lỗi khi cập nhật sản phẩm!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {//Không thì c?p nh?t thành công và g?i hàm loaddata
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            } else
            {//N?u r?ng thì báo l?i và yêu c?u nh?p ??y ??
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!","Thông báo" ,MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Event trigger khi ta nh?n vào nút delete
        private void buttonDel_Click(object sender, EventArgs e)
        {
            string err = "";
            try//b?t l?i n?u có
            {
                int r = dgvProduct.CurrentCell.RowIndex;//??t r là giá tr? c?a ô hi?n t?i trên dgvProduct
                int pro_id = Convert.ToInt32(dgvProduct.Rows[r].Cells["ID"].Value);//??t id c?a product giá tr? c?a c?a ? pro-id c?a hàng r d??i d?ng ki?u int
                if (!dbProduct.deleteProduct(ref err, pro_id))//n?u ko th? xóa product thì s? hi?n ra l?i
                    MessageBox.Show("Lỗi! Không thể xoá sản phẩm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {//Xoa thành công s? hi?n thông báo thành công và loaddata
                    MessageBox.Show("Xoá sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
            catch (Exception)
            {//n?u b?t ???c thì hi?n thông báo th?t b?i
                MessageBox.Show("Xoá sản phẩm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }   

        }
        //Hàm ki?m tra xem giá tr? chu?i truy?n vào có ph?i là s? ko
        //kiêm tra b?ng cách cho nó só sánh v?i giá regex ??t s?n
        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^\d+$");
            return regex.IsMatch(pText);
        }
        //hàm ki?m tra coi có r?ng ko
        //Giai thích cái này nhi?u r?i, t? nh?
        bool IsValid()
        {
            bool check = true;
            if (String.IsNullOrEmpty(txb_proname.Text))
            {
                check = false;
                errorProvider1.SetError(txb_proname, "Required");
            }
            else
            {
                errorProvider1.SetError(txb_proname, "");
            }

            if (String.IsNullOrEmpty(txb_des.Text))
            {
                check = false;
                errorProvider1.SetError(txb_des, "Required");
            }
            else
            {
                errorProvider1.SetError(txb_des, "");
            }

            if (String.IsNullOrEmpty(txb_giaban.Text) || IsNumber(txb_giaban.Text) == false)
            {
                check = false;
                errorProvider1.SetError(txb_giaban, "Required and need a numeric");
            }
            else
            {
                errorProvider1.SetError(txb_giaban, "");
            }

            if (String.IsNullOrEmpty(txb_nhap.Text) || IsNumber(txb_nhap.Text) == false)
            {
                check = false;
                errorProvider1.SetError(txb_nhap, "Required and need a numeric");
            }
            else
            {
                errorProvider1.SetError(txb_nhap, "");
            }


            if (String.IsNullOrEmpty(txb_SL.Text))
            {
                check = false;
                errorProvider1.SetError(txb_SL, "Required");
            }
            else
            {
                errorProvider1.SetError(txb_SL, "");
            }

            return check;
        }
        //Event ?c g?i khi nh?n vào nút clear
        //S? xóa hêt toàn b? nd trên các textbox

        private void btnClear_Click(object sender, EventArgs e)
        {
            txb_proname.Clear();
            txb_SL.Clear();
            txb_nhap.Clear();
            txb_giaban.Clear();
            txb_des.Clear();
        }
    }
}
