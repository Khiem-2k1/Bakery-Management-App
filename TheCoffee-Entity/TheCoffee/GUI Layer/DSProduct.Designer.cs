namespace TheCoffee
{
    partial class DSProduct
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ccbCategories = new System.Windows.Forms.ComboBox();
            this.ccbSupplier = new System.Windows.Forms.ComboBox();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.txb_des = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txb_giaban = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txb_proname = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.txb_nhap = new System.Windows.Forms.TextBox();
            this.txb_SL = new System.Windows.Forms.TextBox();
            this.dtpickerHSD = new System.Windows.Forms.DateTimePicker();
            this.dtpickerNSX = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ccbCategories);
            this.groupBox1.Controls.Add(this.ccbSupplier);
            this.groupBox1.Controls.Add(this.dgvProduct);
            this.groupBox1.Controls.Add(this.txb_des);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txb_giaban);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txb_proname);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.buttonSua);
            this.groupBox1.Controls.Add(this.buttonDel);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.txb_nhap);
            this.groupBox1.Controls.Add(this.txb_SL);
            this.groupBox1.Controls.Add(this.dtpickerHSD);
            this.groupBox1.Controls.Add(this.dtpickerNSX);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1, -26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1918, 965);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // ccbCategories
            // 
            this.ccbCategories.FormattingEnabled = true;
            this.ccbCategories.Location = new System.Drawing.Point(230, 162);
            this.ccbCategories.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ccbCategories.Name = "ccbCategories";
            this.ccbCategories.Size = new System.Drawing.Size(414, 44);
            this.ccbCategories.TabIndex = 50;
            // 
            // ccbSupplier
            // 
            this.ccbSupplier.FormattingEnabled = true;
            this.ccbSupplier.Location = new System.Drawing.Point(230, 102);
            this.ccbSupplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ccbSupplier.Name = "ccbSupplier";
            this.ccbSupplier.Size = new System.Drawing.Size(414, 44);
            this.ccbSupplier.TabIndex = 49;
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.AllowUserToResizeColumns = false;
            this.dgvProduct.AllowUserToResizeRows = false;
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(26, 392);
            this.dgvProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.Size = new System.Drawing.Size(1830, 526);
            this.dgvProduct.TabIndex = 48;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
            // 
            // txb_des
            // 
            this.txb_des.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txb_des.Location = new System.Drawing.Point(228, 292);
            this.txb_des.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_des.Multiline = true;
            this.txb_des.Name = "txb_des";
            this.txb_des.Size = new System.Drawing.Size(1060, 76);
            this.txb_des.TabIndex = 47;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label16.Location = new System.Drawing.Point(127, 312);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 36);
            this.label16.TabIndex = 46;
            this.label16.Text = "Mô tả:";
            // 
            // txb_giaban
            // 
            this.txb_giaban.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txb_giaban.Location = new System.Drawing.Point(990, 101);
            this.txb_giaban.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_giaban.Name = "txb_giaban";
            this.txb_giaban.Size = new System.Drawing.Size(408, 44);
            this.txb_giaban.TabIndex = 45;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label15.Location = new System.Drawing.Point(771, 108);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(222, 36);
            this.label15.TabIndex = 44;
            this.label15.Text = "Giá bán (VND):";
            // 
            // txb_proname
            // 
            this.txb_proname.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txb_proname.Location = new System.Drawing.Point(230, 42);
            this.txb_proname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_proname.Name = "txb_proname";
            this.txb_proname.Size = new System.Drawing.Size(414, 44);
            this.txb_proname.TabIndex = 43;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label14.Location = new System.Drawing.Point(33, 48);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(187, 36);
            this.label14.TabIndex = 42;
            this.label14.Text = "Tên sản phẩm";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.Location = new System.Drawing.Point(72, 168);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(159, 36);
            this.label13.TabIndex = 40;
            this.label13.Text = "Danh mục: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.Location = new System.Drawing.Point(22, 111);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(199, 36);
            this.label12.TabIndex = 38;
            this.label12.Text = "Nhà phân phối";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClear.FlatAppearance.BorderSize = 2;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClear.Location = new System.Drawing.Point(1580, 312);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(276, 61);
            this.btnClear.TabIndex = 37;
            this.btnClear.Text = "Clear ";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.BackColor = System.Drawing.Color.Transparent;
            this.buttonSua.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.buttonSua.FlatAppearance.BorderSize = 2;
            this.buttonSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonSua.ForeColor = System.Drawing.Color.Blue;
            this.buttonSua.Location = new System.Drawing.Point(1580, 145);
            this.buttonSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(276, 61);
            this.buttonSua.TabIndex = 37;
            this.buttonSua.Text = "Cập nhật Sản Phẩm";
            this.buttonSua.UseVisualStyleBackColor = false;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.Transparent;
            this.buttonDel.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonDel.FlatAppearance.BorderSize = 2;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonDel.ForeColor = System.Drawing.Color.Red;
            this.buttonDel.Location = new System.Drawing.Point(1580, 228);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(276, 61);
            this.buttonDel.TabIndex = 36;
            this.buttonDel.Text = "Xóa Sản Phẩm";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonAdd.FlatAppearance.BorderSize = 2;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonAdd.Location = new System.Drawing.Point(1580, 61);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(276, 61);
            this.buttonAdd.TabIndex = 35;
            this.buttonAdd.Text = "Thêm Sản Phẩm";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // txb_nhap
            // 
            this.txb_nhap.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txb_nhap.Location = new System.Drawing.Point(990, 42);
            this.txb_nhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_nhap.Name = "txb_nhap";
            this.txb_nhap.Size = new System.Drawing.Size(408, 44);
            this.txb_nhap.TabIndex = 34;
            // 
            // txb_SL
            // 
            this.txb_SL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txb_SL.Location = new System.Drawing.Point(990, 161);
            this.txb_SL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_SL.Name = "txb_SL";
            this.txb_SL.Size = new System.Drawing.Size(408, 44);
            this.txb_SL.TabIndex = 33;
            // 
            // dtpickerHSD
            // 
            this.dtpickerHSD.CustomFormat = "";
            this.dtpickerHSD.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpickerHSD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpickerHSD.Location = new System.Drawing.Point(990, 228);
            this.dtpickerHSD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpickerHSD.Name = "dtpickerHSD";
            this.dtpickerHSD.Size = new System.Drawing.Size(298, 44);
            this.dtpickerHSD.TabIndex = 31;
            this.dtpickerHSD.Value = new System.DateTime(2022, 11, 3, 0, 0, 0, 0);
            // 
            // dtpickerNSX
            // 
            this.dtpickerNSX.CustomFormat = "";
            this.dtpickerNSX.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpickerNSX.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpickerNSX.Location = new System.Drawing.Point(230, 226);
            this.dtpickerNSX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpickerNSX.Name = "dtpickerNSX";
            this.dtpickerNSX.Size = new System.Drawing.Size(291, 44);
            this.dtpickerNSX.TabIndex = 30;
            this.dtpickerNSX.Value = new System.DateTime(2022, 11, 3, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(807, 235);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 36);
            this.label7.TabIndex = 29;
            this.label7.Text = "Hạn sử dụng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(28, 232);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 36);
            this.label6.TabIndex = 28;
            this.label6.Text = "Ngày sản xuất:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(850, 169);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 36);
            this.label5.TabIndex = 27;
            this.label5.Text = "Số lượng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(770, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 36);
            this.label4.TabIndex = 26;
            this.label4.Text = "Giá gốc (VND):";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DSProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DSProduct";
            this.Size = new System.Drawing.Size(1884, 872);
            this.Load += new System.EventHandler(this.DSProduct_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txb_des;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txb_giaban;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txb_proname;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox txb_nhap;
        private System.Windows.Forms.TextBox txb_SL;
        private System.Windows.Forms.DateTimePicker dtpickerHSD;
        private System.Windows.Forms.DateTimePicker dtpickerNSX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.ComboBox ccbCategories;
        private System.Windows.Forms.ComboBox ccbSupplier;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnClear;
    }
}
