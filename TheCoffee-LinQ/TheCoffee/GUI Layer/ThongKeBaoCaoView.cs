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
    public partial class ThongKeBaoCaoView : UserControl
    {
        public ThongKeDAO thongkeDAO = new ThongKeDAO();
        public OrderDAO orderDAO = new OrderDAO();
        public ThongKeBaoCaoView()
        {
            InitializeComponent();
        }
        //Goi t?i Khi load view thogn ke bao cao
        //Ch?nh các tr?ng thái c?a các radio button và g?i t?i btnOK_click
        private void ThongKeBaoCaoView_Load(object sender, EventArgs e)
        {
            rdAll.Checked = true;
            rdDate.Checked = false;
            btnOK_Click(sender, e);
        }
        //G?i ?én khi nh?n vào nút OK
        //??u tiên th?c hi?n vi?c kt coi nút rdALL ?ã check ch?a?
        //N?u check r?i thì s? gán giá tr? c?a báo cáo doanh thu vào datataasource c?a dgvdstransction
        //Ko thì s? gán giá tr? c?a báo cáo doanh thu t? các tham s? ngày nh?p vào
        //R?i in ra t?ng ti?n
        private void btnOK_Click(object sender, EventArgs e)
        {
            bool check = rdAll.Checked;
            double tong = 0;
           
            TheCoffeDataContext coffe = new TheCoffeDataContext();
            var tkQuery = (from u in coffe.Users
                           from t in coffe.Transactions
                           where u.us_username == t.us_username 
                           select new
                           {
                               t.id,
                               u.us_username,
                               t.totalprice,
                               t.createdate
                           }).ToList();

            var tkQueryDate = (from u in coffe.Users
                               from t in coffe.Transactions
                               where u.us_username == t.us_username
                               && t.createdate >= dateFrom.Value
                               && t.createdate <= dateTo.Value
                               select new
                               {
                                   t.id,
                                   u.us_username,
                                   t.totalprice,
                                   t.createdate
                               }).ToList();

            if (check == true)
            {                
                dgvDSTransaction.DataSource = tkQuery;
                //dgvDSTransaction.DataSource = thongkeDAO.getAllBaoCaoDoanhThu().Tables[0];
            }
            else
            {
                dgvDSTransaction.DataSource = tkQueryDate;
                //dgvDSTransaction.DataSource = thongkeDAO.getBaoCaoDoanhThuDate(dateFrom.Text, dateTo.Text).Tables[0];
            }
            lblTongDon.Text = dgvDSTransaction.Rows.Count.ToString();
            foreach (DataGridViewRow row in dgvDSTransaction.Rows)
            {
                tong += Convert.ToDouble(row.Cells["TotalPrice"].Value);
            }
            lblTongTien.Text = tong + "VND";
        }

      
        //G?i khi nh?n vào ô dgvDSTransaction
        //
        private void dgvDSTransaction_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvDSTransaction.CurrentCell.RowIndex;//??t r = giá tr? hàng c?a ô hi?n t?i c?a dgvDSTransaction
            int transactionID1 = Convert.ToInt32(dgvDSTransaction.Rows[r].Cells["ID"].Value);//??t giá tr? ID c?a ô trên hàng th? r c?a dgvTransaction d??i d?ng ki?u int vào transactionID
            string username = dgvDSTransaction.Rows[r].Cells["username"].Value.ToString();//T??ng t? nh? trên nh?ng mà là username
            
            TheCoffeDataContext coffe = new TheCoffeDataContext();
            var View_DanhSachHangDaDats = 
                               (from u in coffe.Users
                                from o in coffe.Orders
                                from p in coffe.Products
                                from t in coffe.Transactions
                                where u.us_username == o.us_username 
                                && o.productID == p.id
                                && o.transactionID == transactionID1
                               select new
                               {
                                   u.us_username,
                                   transactionID = t.id,
                                   orderID = o.id,
                                   p.pro_name,
                                   o.or_quantity,
                                   o.or_price
                               });

            var voQueryDate = (from vo in View_DanhSachHangDaDats
                               where vo.us_username == username
                               && vo.transactionID == transactionID1
                               select new
                               {
                                  vo.orderID,
                                  vo.pro_name,
                                  vo.or_quantity,
                                  vo.or_price
                               }).ToList();
            dgvOrderDetail.DataSource = voQueryDate;
            //dgvOrderDetail.DataSource = orderDAO.getOrderDetail(username, transactionID).Tables[0];//L?y thong tin c?a ??n hàng dùng 2 giá tr? v?a ki?m ???c và truy?n vao datasource c?a dgvOrderDetail
        }
    }
}
