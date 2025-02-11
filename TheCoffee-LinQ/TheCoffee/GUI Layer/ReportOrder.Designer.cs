namespace TheCoffee.GUI_Layer
{
    partial class ReportOrder
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.viewDanhSachHangDaDatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.theCoffeeDataset = new TheCoffee.TheCoffeeDataset();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.view_DanhSachHangDaDatTableAdapter = new TheCoffee.TheCoffeeDatasetTableAdapters.View_DanhSachHangDaDatTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.viewDanhSachHangDaDatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theCoffeeDataset)).BeginInit();
            this.SuspendLayout();
            // 
            // viewDanhSachHangDaDatBindingSource
            // 
            this.viewDanhSachHangDaDatBindingSource.DataMember = "View_DanhSachHangDaDat";
            this.viewDanhSachHangDaDatBindingSource.DataSource = this.theCoffeeDataset;
            // 
            // theCoffeeDataset
            // 
            this.theCoffeeDataset.DataSetName = "TheCoffeeDataset";
            this.theCoffeeDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(605, 42);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(176, 26);
            this.txtsearch.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(410, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nhập tên người dùng: ";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(814, 40);
            this.search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(111, 30);
            this.search.TabIndex = 6;
            this.search.Text = "Tìm kiếm ";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.viewDanhSachHangDaDatBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TheCoffee.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(381, 97);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(758, 830);
            this.reportViewer1.TabIndex = 9;
            // 
            // view_DanhSachHangDaDatTableAdapter
            // 
            this.view_DanhSachHangDaDatTableAdapter.ClearBeforeFill = true;
            // 
            // ReportOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ReportOrder";
            this.Size = new System.Drawing.Size(1260, 558);
            ((System.ComponentModel.ISupportInitialize)(this.viewDanhSachHangDaDatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theCoffeeDataset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button search;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource viewDanhSachHangDaDatBindingSource;
        private TheCoffeeDataset theCoffeeDataset;
        private TheCoffeeDatasetTableAdapters.View_DanhSachHangDaDatTableAdapter view_DanhSachHangDaDatTableAdapter;
    }
}
