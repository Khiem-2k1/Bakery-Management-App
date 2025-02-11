namespace TheCoffee
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlView = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNamePage = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnDoanhThu = new System.Windows.Forms.Button();
            this.pnlSubMenuDanhMuc = new System.Windows.Forms.Panel();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnSanPham = new System.Windows.Forms.Button();
            this.btnDanhMuc = new System.Windows.Forms.Button();
            this.pnlSubMenuThongTin = new System.Windows.Forms.Panel();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.btnChinhSuaThongTin = new System.Windows.Forms.Button();
            this.btnThongTin = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.baocao = new System.Windows.Forms.Button();
            this.pnlView.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlSubMenuDanhMuc.SuspendLayout();
            this.pnlSubMenuThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlView
            // 
            this.pnlView.BackColor = System.Drawing.Color.White;
            this.pnlView.Controls.Add(this.panel2);
            this.pnlView.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlView.Location = new System.Drawing.Point(9, 0);
            this.pnlView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(1937, 1064);
            this.pnlView.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.lblNamePage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1937, 92);
            this.panel2.TabIndex = 81;
            // 
            // lblNamePage
            // 
            this.lblNamePage.AutoSize = true;
            this.lblNamePage.Font = new System.Drawing.Font("Trebuchet MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamePage.ForeColor = System.Drawing.Color.White;
            this.lblNamePage.Location = new System.Drawing.Point(138, 21);
            this.lblNamePage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNamePage.Name = "lblNamePage";
            this.lblNamePage.Size = new System.Drawing.Size(129, 49);
            this.lblNamePage.TabIndex = 0;
            this.lblNamePage.Text = "Home";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.baocao);
            this.panel1.Controls.Add(this.btnDangXuat);
            this.panel1.Controls.Add(this.btnDoanhThu);
            this.panel1.Controls.Add(this.pnlSubMenuDanhMuc);
            this.panel1.Controls.Add(this.btnDanhMuc);
            this.panel1.Controls.Add(this.pnlSubMenuThongTin);
            this.panel1.Controls.Add(this.btnThongTin);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 1064);
            this.panel1.TabIndex = 2;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.Image")));
            this.btnDangXuat.Location = new System.Drawing.Point(0, 972);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(368, 90);
            this.btnDangXuat.TabIndex = 4;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnDoanhThu
            // 
            this.btnDoanhThu.BackColor = System.Drawing.Color.White;
            this.btnDoanhThu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoanhThu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoanhThu.FlatAppearance.BorderSize = 0;
            this.btnDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoanhThu.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoanhThu.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnDoanhThu.Location = new System.Drawing.Point(0, 739);
            this.btnDoanhThu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDoanhThu.Name = "btnDoanhThu";
            this.btnDoanhThu.Size = new System.Drawing.Size(368, 92);
            this.btnDoanhThu.TabIndex = 3;
            this.btnDoanhThu.Text = "Doanh thu";
            this.btnDoanhThu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDoanhThu.UseVisualStyleBackColor = false;
            this.btnDoanhThu.Click += new System.EventHandler(this.btnDoanhThu_Click);
            // 
            // pnlSubMenuDanhMuc
            // 
            this.pnlSubMenuDanhMuc.Controls.Add(this.btnNhanVien);
            this.pnlSubMenuDanhMuc.Controls.Add(this.btnKhachHang);
            this.pnlSubMenuDanhMuc.Controls.Add(this.btnSanPham);
            this.pnlSubMenuDanhMuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuDanhMuc.Location = new System.Drawing.Point(0, 461);
            this.pnlSubMenuDanhMuc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlSubMenuDanhMuc.Name = "pnlSubMenuDanhMuc";
            this.pnlSubMenuDanhMuc.Size = new System.Drawing.Size(368, 278);
            this.pnlSubMenuDanhMuc.TabIndex = 5;
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(189)))), ((int)(((byte)(194)))));
            this.btnNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.Color.Black;
            this.btnNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.Image")));
            this.btnNhanVien.Location = new System.Drawing.Point(0, 184);
            this.btnNhanVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(368, 92);
            this.btnNhanVien.TabIndex = 5;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhanVien.UseVisualStyleBackColor = false;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(189)))), ((int)(((byte)(194)))));
            this.btnKhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKhachHang.FlatAppearance.BorderSize = 0;
            this.btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachHang.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachHang.ForeColor = System.Drawing.Color.Black;
            this.btnKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("btnKhachHang.Image")));
            this.btnKhachHang.Location = new System.Drawing.Point(0, 92);
            this.btnKhachHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(368, 92);
            this.btnKhachHang.TabIndex = 3;
            this.btnKhachHang.Text = "Khách hàng";
            this.btnKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKhachHang.UseVisualStyleBackColor = false;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnSanPham
            // 
            this.btnSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(189)))), ((int)(((byte)(194)))));
            this.btnSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSanPham.FlatAppearance.BorderSize = 0;
            this.btnSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSanPham.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSanPham.ForeColor = System.Drawing.Color.Black;
            this.btnSanPham.Image = ((System.Drawing.Image)(resources.GetObject("btnSanPham.Image")));
            this.btnSanPham.Location = new System.Drawing.Point(0, 0);
            this.btnSanPham.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Size = new System.Drawing.Size(368, 92);
            this.btnSanPham.TabIndex = 4;
            this.btnSanPham.Text = "Sản phẩm";
            this.btnSanPham.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSanPham.UseVisualStyleBackColor = false;
            this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);
            // 
            // btnDanhMuc
            // 
            this.btnDanhMuc.BackColor = System.Drawing.Color.White;
            this.btnDanhMuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDanhMuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDanhMuc.FlatAppearance.BorderSize = 0;
            this.btnDanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhMuc.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhMuc.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnDanhMuc.Location = new System.Drawing.Point(0, 369);
            this.btnDanhMuc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Size = new System.Drawing.Size(368, 92);
            this.btnDanhMuc.TabIndex = 4;
            this.btnDanhMuc.Text = "Danh mục";
            this.btnDanhMuc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDanhMuc.UseVisualStyleBackColor = false;
            this.btnDanhMuc.Click += new System.EventHandler(this.btnDanhMuc_Click);
            // 
            // pnlSubMenuThongTin
            // 
            this.pnlSubMenuThongTin.Controls.Add(this.btnDoiMatKhau);
            this.pnlSubMenuThongTin.Controls.Add(this.btnChinhSuaThongTin);
            this.pnlSubMenuThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuThongTin.Location = new System.Drawing.Point(0, 184);
            this.pnlSubMenuThongTin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlSubMenuThongTin.Name = "pnlSubMenuThongTin";
            this.pnlSubMenuThongTin.Size = new System.Drawing.Size(368, 185);
            this.pnlSubMenuThongTin.TabIndex = 1;
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(189)))), ((int)(((byte)(194)))));
            this.btnDoiMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoiMatKhau.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoiMatKhau.FlatAppearance.BorderSize = 0;
            this.btnDoiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMatKhau.ForeColor = System.Drawing.Color.Black;
            this.btnDoiMatKhau.Image = ((System.Drawing.Image)(resources.GetObject("btnDoiMatKhau.Image")));
            this.btnDoiMatKhau.Location = new System.Drawing.Point(0, 92);
            this.btnDoiMatKhau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(368, 92);
            this.btnDoiMatKhau.TabIndex = 2;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDoiMatKhau.UseVisualStyleBackColor = false;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // btnChinhSuaThongTin
            // 
            this.btnChinhSuaThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(189)))), ((int)(((byte)(194)))));
            this.btnChinhSuaThongTin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChinhSuaThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChinhSuaThongTin.FlatAppearance.BorderSize = 0;
            this.btnChinhSuaThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChinhSuaThongTin.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChinhSuaThongTin.ForeColor = System.Drawing.Color.Black;
            this.btnChinhSuaThongTin.Image = ((System.Drawing.Image)(resources.GetObject("btnChinhSuaThongTin.Image")));
            this.btnChinhSuaThongTin.Location = new System.Drawing.Point(0, 0);
            this.btnChinhSuaThongTin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChinhSuaThongTin.Name = "btnChinhSuaThongTin";
            this.btnChinhSuaThongTin.Size = new System.Drawing.Size(368, 92);
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
            this.btnThongTin.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongTin.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnThongTin.Location = new System.Drawing.Point(0, 92);
            this.btnThongTin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThongTin.Name = "btnThongTin";
            this.btnThongTin.Size = new System.Drawing.Size(368, 92);
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
            this.btnHome.Font = new System.Drawing.Font("Trebuchet MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(368, 92);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // baocao
            // 
            this.baocao.BackColor = System.Drawing.Color.White;
            this.baocao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.baocao.Dock = System.Windows.Forms.DockStyle.Top;
            this.baocao.FlatAppearance.BorderSize = 0;
            this.baocao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.baocao.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baocao.ForeColor = System.Drawing.Color.DarkCyan;
            this.baocao.Location = new System.Drawing.Point(0, 831);
            this.baocao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.baocao.Name = "baocao";
            this.baocao.Size = new System.Drawing.Size(368, 92);
            this.baocao.TabIndex = 6;
            this.baocao.Text = "Báo cáo ";
            this.baocao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.baocao.UseVisualStyleBackColor = false;
            this.baocao.Click += new System.EventHandler(this.baocao_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1946, 1064);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(2873, 1648);
            this.MinimumSize = new System.Drawing.Size(1918, 1006);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mainform";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlView.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlSubMenuDanhMuc.ResumeLayout(false);
            this.pnlSubMenuThongTin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnDoanhThu;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnSanPham;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Panel pnlSubMenuThongTin;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.Button btnChinhSuaThongTin;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnThongTin;
        private System.Windows.Forms.Panel pnlSubMenuDanhMuc;
        private System.Windows.Forms.Button btnDanhMuc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNamePage;
        private System.Windows.Forms.Button baocao;
    }
}