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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.label1 = new System.Windows.Forms.Label();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.theCoffeeDataSet = new TheCoffee.TheCoffeeDataSet();
            this.viewDanhSachHangDaDatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_DanhSachHangDaDatTableAdapter = new TheCoffee.TheCoffeeDataSetTableAdapters.View_DanhSachHangDaDatTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.theCoffeeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDanhSachHangDaDatBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập tên người dùng:";
            // 
            // txbSearch
            // 
            this.txbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearch.Location = new System.Drawing.Point(396, 61);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(214, 30);
            this.txbSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(643, 61);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(106, 34);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.viewDanhSachHangDaDatBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TheCoffee.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(108, 152);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(870, 700);
            this.reportViewer1.TabIndex = 4;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load_1);
            // 
            // theCoffeeDataSet
            // 
            this.theCoffeeDataSet.DataSetName = "TheCoffeeDataSet";
            this.theCoffeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewDanhSachHangDaDatBindingSource
            // 
            this.viewDanhSachHangDaDatBindingSource.DataMember = "View_DanhSachHangDaDat";
            this.viewDanhSachHangDaDatBindingSource.DataSource = this.theCoffeeDataSet;
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
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txbSearch);
            this.Controls.Add(this.label1);
            this.Name = "ReportOrder";
            this.Size = new System.Drawing.Size(1087, 743);
            ((System.ComponentModel.ISupportInitialize)(this.theCoffeeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDanhSachHangDaDatBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Button btnSearch;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource viewDanhSachHangDaDatBindingSource;
        private TheCoffeeDataSet theCoffeeDataSet;
        private TheCoffeeDataSetTableAdapters.View_DanhSachHangDaDatTableAdapter view_DanhSachHangDaDatTableAdapter;
    }
}
