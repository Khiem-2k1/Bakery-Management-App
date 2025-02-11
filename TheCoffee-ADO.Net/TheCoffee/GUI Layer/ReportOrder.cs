using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheCoffee.GUI_Layer
{
    public partial class ReportOrder : UserControl
    {
        public ReportOrder()
        {
            InitializeComponent();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            this.view_DanhSachHangDaDatTableAdapter.Fill(this.theCoffeeDataset.View_DanhSachHangDaDat, txtsearch.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
