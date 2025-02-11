namespace TheCoffee
{
    partial class MainFormCustomer
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormCustomer));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlView = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnQuanLiDonHang = new System.Windows.Forms.Button();
            this.btnGioHang = new System.Windows.Forms.Button();
            this.pnlSubMenuThongTin = new System.Windows.Forms.Panel();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.btnChinhSuaThongTin = new System.Windows.Forms.Button();
            this.btnThongTin = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNamePage = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlSubMenuThongTin.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(469, 12);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(896, 48);
            this.txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(1293, 17);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(67, 39);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlView
            // 
            this.pnlView.Location = new System.Drawing.Point(329, 74);
            this.pnlView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(1720, 990);
            this.pnlView.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnDangXuat);
            this.panel1.Controls.Add(this.btnQuanLiDonHang);
            this.panel1.Controls.Add(this.btnGioHang);
            this.panel1.Controls.Add(this.pnlSubMenuThongTin);
            this.panel1.Controls.Add(this.btnThongTin);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 814);
            this.panel1.TabIndex = 5;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.DarkCyan;
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.Image")));
            this.btnDangXuat.Location = new System.Drawing.Point(0, 740);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(329, 74);
            this.btnDangXuat.TabIndex = 4;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnQuanLiDonHang
            // 
            this.btnQuanLiDonHang.BackColor = System.Drawing.Color.White;
            this.btnQuanLiDonHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuanLiDonHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLiDonHang.FlatAppearance.BorderSize = 0;
            this.btnQuanLiDonHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLiDonHang.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLiDonHang.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnQuanLiDonHang.Location = new System.Drawing.Point(0, 370);
            this.btnQuanLiDonHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuanLiDonHang.Name = "btnQuanLiDonHang";
            this.btnQuanLiDonHang.Size = new System.Drawing.Size(329, 74);
            this.btnQuanLiDonHang.TabIndex = 3;
            this.btnQuanLiDonHang.Text = "Quản lí đơn hàng";
            this.btnQuanLiDonHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuanLiDonHang.UseVisualStyleBackColor = false;
            this.btnQuanLiDonHang.Click += new System.EventHandler(this.btnQuanLiDonHang_Click);
            // 
            // btnGioHang
            // 
            this.btnGioHang.BackColor = System.Drawing.Color.White;
            this.btnGioHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGioHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGioHang.FlatAppearance.BorderSize = 0;
            this.btnGioHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGioHang.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGioHang.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnGioHang.Location = new System.Drawing.Point(0, 296);
            this.btnGioHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGioHang.Name = "btnGioHang";
            this.btnGioHang.Size = new System.Drawing.Size(329, 74);
            this.btnGioHang.TabIndex = 4;
            this.btnGioHang.Text = "Giỏ hàng";
            this.btnGioHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGioHang.UseVisualStyleBackColor = false;
            this.btnGioHang.Click += new System.EventHandler(this.btnGioHang_Click);
            // 
            // pnlSubMenuThongTin
            // 
            this.pnlSubMenuThongTin.Controls.Add(this.btnDoiMatKhau);
            this.pnlSubMenuThongTin.Controls.Add(this.btnChinhSuaThongTin);
            this.pnlSubMenuThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuThongTin.Location = new System.Drawing.Point(0, 148);
            this.pnlSubMenuThongTin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlSubMenuThongTin.Name = "pnlSubMenuThongTin";
            this.pnlSubMenuThongTin.Size = new System.Drawing.Size(329, 148);
            this.pnlSubMenuThongTin.TabIndex = 1;
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDoiMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoiMatKhau.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoiMatKhau.FlatAppearance.BorderSize = 0;
            this.btnDoiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMatKhau.ForeColor = System.Drawing.Color.White;
            this.btnDoiMatKhau.Image = ((System.Drawing.Image)(resources.GetObject("btnDoiMatKhau.Image")));
            this.btnDoiMatKhau.Location = new System.Drawing.Point(0, 74);
            this.btnDoiMatKhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(329, 74);
            this.btnDoiMatKhau.TabIndex = 2;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDoiMatKhau.UseVisualStyleBackColor = false;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // btnChinhSuaThongTin
            // 
            this.btnChinhSuaThongTin.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnChinhSuaThongTin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChinhSuaThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChinhSuaThongTin.FlatAppearance.BorderSize = 0;
            this.btnChinhSuaThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChinhSuaThongTin.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChinhSuaThongTin.ForeColor = System.Drawing.Color.White;
            this.btnChinhSuaThongTin.Image = ((System.Drawing.Image)(resources.GetObject("btnChinhSuaThongTin.Image")));
            this.btnChinhSuaThongTin.Location = new System.Drawing.Point(0, 0);
            this.btnChinhSuaThongTin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChinhSuaThongTin.Name = "btnChinhSuaThongTin";
            this.btnChinhSuaThongTin.Size = new System.Drawing.Size(329, 74);
            this.btnChinhSuaThongTin.TabIndex = 1;
            this.btnChinhSuaThongTin.Text = "Chỉnh sửa thông tin";
            this.btnChinhSuaThongTin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChinhSuaThongTin.UseVisualStyleBackColor = false;
            this.btnChinhSuaThongTin.Click += new System.EventHandler(this.btnChinhSuaThongTin_Click);
            // 
            // btnThongTin
            // 
            this.btnThongTin.BackColor = System.Drawing.Color.White;
            this.btnThongTin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongTin.FlatAppearance.BorderSize = 0;
            this.btnThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongTin.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongTin.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnThongTin.Location = new System.Drawing.Point(0, 74);
            this.btnThongTin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThongTin.Name = "btnThongTin";
            this.btnThongTin.Size = new System.Drawing.Size(329, 74);
            this.btnThongTin.TabIndex = 3;
            this.btnThongTin.Text = "Thông tin cá nhân";
            this.btnThongTin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongTin.UseVisualStyleBackColor = false;
            this.btnThongTin.Click += new System.EventHandler(this.btnThongTin_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.DarkCyan;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(329, 74);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.lblNamePage);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(329, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1397, 74);
            this.panel2.TabIndex = 81;
            // 
            // lblNamePage
            // 
            this.lblNamePage.AutoSize = true;
            this.lblNamePage.Font = new System.Drawing.Font("Trebuchet MS", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamePage.ForeColor = System.Drawing.Color.White;
            this.lblNamePage.Location = new System.Drawing.Point(-9, 12);
            this.lblNamePage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNamePage.Name = "lblNamePage";
            this.lblNamePage.Size = new System.Drawing.Size(138, 54);
            this.lblNamePage.TabIndex = 0;
            this.lblNamePage.Text = "Home";
            // 
            // MainFormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1726, 814);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainFormCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainFormCustomer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainFormCustomer_Load);
            this.panel1.ResumeLayout(false);
            this.pnlSubMenuThongTin.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnlView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnQuanLiDonHang;
        private System.Windows.Forms.Button btnGioHang;
        private System.Windows.Forms.Panel pnlSubMenuThongTin;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.Button btnChinhSuaThongTin;
        private System.Windows.Forms.Button btnThongTin;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNamePage;
    }
}