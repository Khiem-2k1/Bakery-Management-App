
namespace TheCoffee
{
    partial class DSUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbbRole = new System.Windows.Forms.ComboBox();
            this.rdGenderMale = new System.Windows.Forms.RadioButton();
            this.rdGenderFemale = new System.Windows.Forms.RadioButton();
            this.btn_clearfrm = new System.Windows.Forms.Button();
            this.txb_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dt_birth = new System.Windows.Forms.DateTimePicker();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txb_phone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txb_address = new System.Windows.Forms.TextBox();
            this.lb_address = new System.Windows.Forms.Label();
            this.txb_lastname = new System.Windows.Forms.TextBox();
            this.lblastname = new System.Windows.Forms.Label();
            this.txb_firstname = new System.Windows.Forms.TextBox();
            this.ldfirstname = new System.Windows.Forms.Label();
            this.txb_pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbrole = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.username,
            this.firstname,
            this.lastname,
            this.address,
            this.birthday,
            this.gender,
            this.phone,
            this.email});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(32, 34);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1821, 421);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // username
            // 
            this.username.DataPropertyName = "us_username";
            this.username.HeaderText = "Username";
            this.username.MinimumWidth = 6;
            this.username.Name = "username";
            this.username.Width = 130;
            // 
            // firstname
            // 
            this.firstname.DataPropertyName = "us_firstname";
            this.firstname.HeaderText = "Firstname";
            this.firstname.MinimumWidth = 6;
            this.firstname.Name = "firstname";
            this.firstname.Width = 130;
            // 
            // lastname
            // 
            this.lastname.DataPropertyName = "us_lastname";
            this.lastname.HeaderText = "Lastname";
            this.lastname.MinimumWidth = 6;
            this.lastname.Name = "lastname";
            this.lastname.Width = 130;
            // 
            // address
            // 
            this.address.DataPropertyName = "us_address";
            this.address.HeaderText = "Address";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            this.address.Width = 130;
            // 
            // birthday
            // 
            this.birthday.DataPropertyName = "us_birthday";
            this.birthday.HeaderText = "Birthday";
            this.birthday.MinimumWidth = 6;
            this.birthday.Name = "birthday";
            this.birthday.Width = 130;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "us_gender";
            this.gender.HeaderText = "Gender";
            this.gender.MinimumWidth = 6;
            this.gender.Name = "gender";
            this.gender.Width = 130;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "us_phone";
            this.phone.HeaderText = "Phone";
            this.phone.MinimumWidth = 6;
            this.phone.Name = "phone";
            this.phone.Width = 130;
            // 
            // email
            // 
            this.email.DataPropertyName = "us_email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.Width = 130;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cbbRole
            // 
            this.cbbRole.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbRole.FormattingEnabled = true;
            this.cbbRole.Location = new System.Drawing.Point(1462, 726);
            this.cbbRole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbRole.Name = "cbbRole";
            this.cbbRole.Size = new System.Drawing.Size(320, 44);
            this.cbbRole.TabIndex = 132;
            // 
            // rdGenderMale
            // 
            this.rdGenderMale.AutoSize = true;
            this.rdGenderMale.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdGenderMale.Location = new System.Drawing.Point(1464, 574);
            this.rdGenderMale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdGenderMale.Name = "rdGenderMale";
            this.rdGenderMale.Size = new System.Drawing.Size(105, 40);
            this.rdGenderMale.TabIndex = 131;
            this.rdGenderMale.TabStop = true;
            this.rdGenderMale.Text = "Male";
            this.rdGenderMale.UseVisualStyleBackColor = true;
            // 
            // rdGenderFemale
            // 
            this.rdGenderFemale.AutoSize = true;
            this.rdGenderFemale.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdGenderFemale.Location = new System.Drawing.Point(1652, 575);
            this.rdGenderFemale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdGenderFemale.Name = "rdGenderFemale";
            this.rdGenderFemale.Size = new System.Drawing.Size(132, 40);
            this.rdGenderFemale.TabIndex = 130;
            this.rdGenderFemale.TabStop = true;
            this.rdGenderFemale.Text = "Female";
            this.rdGenderFemale.UseVisualStyleBackColor = true;
            // 
            // btn_clearfrm
            // 
            this.btn_clearfrm.BackColor = System.Drawing.Color.Transparent;
            this.btn_clearfrm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_clearfrm.FlatAppearance.BorderSize = 2;
            this.btn_clearfrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clearfrm.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearfrm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_clearfrm.Location = new System.Drawing.Point(1545, 812);
            this.btn_clearfrm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_clearfrm.Name = "btn_clearfrm";
            this.btn_clearfrm.Size = new System.Drawing.Size(177, 60);
            this.btn_clearfrm.TabIndex = 129;
            this.btn_clearfrm.Text = "Clear";
            this.btn_clearfrm.UseVisualStyleBackColor = false;
            // 
            // txb_email
            // 
            this.txb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_email.Location = new System.Drawing.Point(204, 729);
            this.txb_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_email.Name = "txb_email";
            this.txb_email.Size = new System.Drawing.Size(1016, 43);
            this.txb_email.TabIndex = 128;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 734);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 36);
            this.label3.TabIndex = 127;
            this.label3.Text = "Email:";
            // 
            // dt_birth
            // 
            this.dt_birth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_birth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_birth.Location = new System.Drawing.Point(1462, 498);
            this.dt_birth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dt_birth.Name = "dt_birth";
            this.dt_birth.Size = new System.Drawing.Size(320, 43);
            this.dt_birth.TabIndex = 126;
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.Transparent;
            this.btn_xoa.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_xoa.FlatAppearance.BorderSize = 2;
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.Red;
            this.btn_xoa.Location = new System.Drawing.Point(1108, 812);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(177, 60);
            this.btn_xoa.TabIndex = 125;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.BackColor = System.Drawing.Color.Transparent;
            this.btn_capnhat.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_capnhat.FlatAppearance.BorderSize = 2;
            this.btn_capnhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_capnhat.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_capnhat.ForeColor = System.Drawing.Color.Blue;
            this.btn_capnhat.Location = new System.Drawing.Point(663, 812);
            this.btn_capnhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(177, 60);
            this.btn_capnhat.TabIndex = 124;
            this.btn_capnhat.Text = "Cập nhật";
            this.btn_capnhat.UseVisualStyleBackColor = false;
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.Transparent;
            this.btn_Them.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Them.FlatAppearance.BorderSize = 2;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Them.Location = new System.Drawing.Point(248, 812);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(177, 60);
            this.btn_Them.TabIndex = 123;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txb_phone
            // 
            this.txb_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_phone.Location = new System.Drawing.Point(1462, 649);
            this.txb_phone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_phone.Name = "txb_phone";
            this.txb_phone.Size = new System.Drawing.Size(320, 43);
            this.txb_phone.TabIndex = 122;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1358, 655);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 36);
            this.label7.TabIndex = 121;
            this.label7.Text = "Phone:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1344, 578);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 36);
            this.label8.TabIndex = 120;
            this.label8.Text = "Gender: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1329, 502);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 36);
            this.label9.TabIndex = 119;
            this.label9.Text = "Birthday:";
            // 
            // txb_address
            // 
            this.txb_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_address.Location = new System.Drawing.Point(204, 652);
            this.txb_address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_address.Name = "txb_address";
            this.txb_address.Size = new System.Drawing.Size(1016, 43);
            this.txb_address.TabIndex = 118;
            // 
            // lb_address
            // 
            this.lb_address.AutoSize = true;
            this.lb_address.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_address.Location = new System.Drawing.Point(78, 658);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(125, 36);
            this.lb_address.TabIndex = 117;
            this.lb_address.Text = "Address:";
            // 
            // txb_lastname
            // 
            this.txb_lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_lastname.Location = new System.Drawing.Point(775, 574);
            this.txb_lastname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_lastname.Name = "txb_lastname";
            this.txb_lastname.Size = new System.Drawing.Size(445, 43);
            this.txb_lastname.TabIndex = 116;
            // 
            // lblastname
            // 
            this.lblastname.AutoSize = true;
            this.lblastname.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblastname.Location = new System.Drawing.Point(622, 580);
            this.lblastname.Name = "lblastname";
            this.lblastname.Size = new System.Drawing.Size(151, 36);
            this.lblastname.TabIndex = 115;
            this.lblastname.Text = "Last name:";
            // 
            // txb_firstname
            // 
            this.txb_firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_firstname.Location = new System.Drawing.Point(775, 492);
            this.txb_firstname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_firstname.Name = "txb_firstname";
            this.txb_firstname.Size = new System.Drawing.Size(445, 43);
            this.txb_firstname.TabIndex = 114;
            // 
            // ldfirstname
            // 
            this.ldfirstname.AutoSize = true;
            this.ldfirstname.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldfirstname.Location = new System.Drawing.Point(616, 499);
            this.ldfirstname.Name = "ldfirstname";
            this.ldfirstname.Size = new System.Drawing.Size(156, 36);
            this.ldfirstname.TabIndex = 113;
            this.ldfirstname.Text = "First name:";
            // 
            // txb_pass
            // 
            this.txb_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_pass.Location = new System.Drawing.Point(204, 571);
            this.txb_pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_pass.Name = "txb_pass";
            this.txb_pass.PasswordChar = '*';
            this.txb_pass.Size = new System.Drawing.Size(364, 43);
            this.txb_pass.TabIndex = 111;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 578);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 36);
            this.label2.TabIndex = 110;
            this.label2.Text = "Password:";
            // 
            // txb_username
            // 
            this.txb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_username.Location = new System.Drawing.Point(206, 492);
            this.txb_username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_username.Name = "txb_username";
            this.txb_username.Size = new System.Drawing.Size(364, 43);
            this.txb_username.TabIndex = 109;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 36);
            this.label1.TabIndex = 108;
            this.label1.Text = "User name:";
            // 
            // lbrole
            // 
            this.lbrole.AutoSize = true;
            this.lbrole.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrole.Location = new System.Drawing.Point(1376, 732);
            this.lbrole.Name = "lbrole";
            this.lbrole.Size = new System.Drawing.Size(84, 36);
            this.lbrole.TabIndex = 112;
            this.lbrole.Text = "Role:";
            // 
            // DSUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbbRole);
            this.Controls.Add(this.rdGenderMale);
            this.Controls.Add(this.rdGenderFemale);
            this.Controls.Add(this.btn_clearfrm);
            this.Controls.Add(this.txb_email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dt_birth);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_capnhat);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txb_phone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txb_address);
            this.Controls.Add(this.lb_address);
            this.Controls.Add(this.txb_lastname);
            this.Controls.Add(this.lblastname);
            this.Controls.Add(this.txb_firstname);
            this.Controls.Add(this.ldfirstname);
            this.Controls.Add(this.txb_pass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbrole);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DSUser";
            this.Size = new System.Drawing.Size(1884, 965);
            this.Load += new System.EventHandler(this.User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.ComboBox cbbRole;
        private System.Windows.Forms.RadioButton rdGenderMale;
        private System.Windows.Forms.RadioButton rdGenderFemale;
        private System.Windows.Forms.Button btn_clearfrm;
        private System.Windows.Forms.TextBox txb_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dt_birth;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_capnhat;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txb_phone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txb_address;
        private System.Windows.Forms.Label lb_address;
        private System.Windows.Forms.TextBox txb_lastname;
        private System.Windows.Forms.Label lblastname;
        private System.Windows.Forms.TextBox txb_firstname;
        private System.Windows.Forms.Label ldfirstname;
        private System.Windows.Forms.TextBox txb_pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbrole;
    }
}
