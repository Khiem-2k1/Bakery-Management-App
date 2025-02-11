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
using System.Windows.Shapes;
using System.Xml.Linq;

namespace TheCoffee
{
    public partial class timKiemSanPhamTheoTenView : UserControl
    {
        public delegate void ThemVaoGioHang(Order1 oder);
        public ThemVaoGioHang themVaoGioHang;

        private ProductDAO db = new ProductDAO();
        private User1 user { set; get; }

        private string productName;
        public  timKiemSanPhamTheoTenView()
        {
            InitializeComponent();
        }
        //??t các thu?c tính = các giá tr? truy?n vào
        public timKiemSanPhamTheoTenView(string productname, User1 user)
        {
            InitializeComponent();
            this.productName = productname;
            this.user = user;
            this.user.listOrder = new List<Order1>();
            pnlThemGioHang.Visible = false;
        }
        //G?i khi load view timkiem...
        //truy?n d? li?u ?ã trim t? table c?a db timkiemsan... vào datasource c?a dgvtimkiemsanpham
        private void timKiemSanPhamTheoTenView_Load(object sender, EventArgs e)
        {
            TheCoffeDataContext coffe = new TheCoffeDataContext();
            var spQuery = (from p in coffe.Products
                           from c in coffe.Categories
                           from s in coffe.Suppliers
                           where p.categoriesID == c.id && p.supplierID == s.id && p.pro_name.Contains(this.productName.Trim())
                           select new
                           {
                               p.id,
                               p.pro_name,
                               p.pro_quantity,
                               p.pro_price,
                               p.pro_nsx,
                               p.pro_hsd,
                               p.pro_description,
                               s.sup_name,
                               c.cate_name
                           }).ToList();
            dgvTimKiemSanPham.DataSource = spQuery;
            //dgvTimKiemSanPham.DataSource = db.timKiemSanPhamTheoTen(this.productName.Trim()).Tables[0];
        }
        //g?i khi nh?n vào dgvTimKiemSanPham_Cell
        //??t bi?n ki?u int r = v? trí hàng c?a ô hi?n t?i trên dgvtimkiem...
        //??t product = giá tr? c?a ô th? 0 trên hàng th? r c?a dgv
        //Th?c hiejn vi?c truyên giá tr? vào các controls r?i ??t ?? visible c?a pnlThemGioHang=true
        private void dgvTimKiemSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvTimKiemSanPham.CurrentCell.RowIndex;
            Product1 product = db.getProduct((int) dgvTimKiemSanPham.Rows[r].Cells[0].Value);

            lblProductID.Text = product.id.ToString();
            lblProductName.Text = product.name;
            lblProductPrice.Text = product.price.ToString();
            lblTotalPrice.Text = (product.price * (float)numericUpDown1.Value) + "VND";
            numericUpDown1.Maximum = product.quantity;
            numericUpDown1.Value = 1;
            
            lblMax.Text = "(Còn lại: " + product.quantity + ")";

            pnlThemGioHang.Visible = true;
        }


       
        //truy?n d? li?u t? các controles sang các thu?c tính c?a order
        //n?u gi? hàng ko r?ng thì th?c hi?n them gi? hàng v?i tham s? order và hi?n thông báo thành công
        

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            int quantity = (int)numericUpDown1.Value;
            int productID = int.Parse(lblProductID.Text);
            Order1 order = new Order1();
            order.quantity = quantity;
            order.productID = productID;
            order.username = user.username;
            order.productName = lblProductName.Text;
            order.price = double.Parse(lblProductPrice.Text) * (double)numericUpDown1.Value;

            if (themVaoGioHang != null)
            {
                themVaoGioHang(order);
                MessageBox.Show("Đã thêm vào giỏ hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //??t visible c?a pnlthemgiohang =false
        private void btnHuy_Click(object sender, EventArgs e)
        {
            pnlThemGioHang.Visible = false;
        }
        //goi khi gia tri numericupdown thay doi
        //??t l?i giá tr? cho lbl totalprice
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            lblTotalPrice.Text = (double.Parse(lblProductPrice.Text) * (double)numericUpDown1.Value).ToString() + "VND";
        }
    }
}
