namespace TheCoffee
{
    partial class inFoAccountView
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnUpdateInfo = new System.Windows.Forms.Button();
            this.rdGenderMale = new System.Windows.Forms.RadioButton();
            this.rdGenderFemale = new System.Windows.Forms.RadioButton();
            this.txb_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dt_birth = new System.Windows.Forms.DateTimePicker();
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
            this.lblRole = new System.Windows.Forms.Label();
            this.lbrole = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnReset.FlatAppearance.BorderSize = 2;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Blue;
            this.btnReset.Location = new System.Drawing.Point(762, 700);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(446, 55);
            this.btnReset.TabIndex = 96;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnUpdateInfo
            // 
            this.btnUpdateInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUpdateInfo.FlatAppearance.BorderSize = 2;
            this.btnUpdateInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateInfo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUpdateInfo.Location = new System.Drawing.Point(166, 700);
            this.btnUpdateInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateInfo.Name = "btnUpdateInfo";
            this.btnUpdateInfo.Size = new System.Drawing.Size(446, 55);
            this.btnUpdateInfo.TabIndex = 95;
            this.btnUpdateInfo.Text = "Cập nhật thông tin";
            this.btnUpdateInfo.UseVisualStyleBackColor = false;
            this.btnUpdateInfo.Click += new System.EventHandler(this.btnUpdateInfo_Click);
            // 
            // rdGenderMale
            // 
            this.rdGenderMale.AutoSize = true;
            this.rdGenderMale.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdGenderMale.Location = new System.Drawing.Point(244, 211);
            this.rdGenderMale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdGenderMale.Name = "rdGenderMale";
            this.rdGenderMale.Size = new System.Drawing.Size(105, 40);
            this.rdGenderMale.TabIndex = 94;
            this.rdGenderMale.TabStop = true;
            this.rdGenderMale.Text = "Male";
            this.rdGenderMale.UseVisualStyleBackColor = true;
            // 
            // rdGenderFemale
            // 
            this.rdGenderFemale.AutoSize = true;
            this.rdGenderFemale.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdGenderFemale.Location = new System.Drawing.Point(408, 211);
            this.rdGenderFemale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdGenderFemale.Name = "rdGenderFemale";
            this.rdGenderFemale.Size = new System.Drawing.Size(132, 40);
            this.rdGenderFemale.TabIndex = 93;
            this.rdGenderFemale.TabStop = true;
            this.rdGenderFemale.Text = "Female";
            this.rdGenderFemale.UseVisualStyleBackColor = true;
            // 
            // txb_email
            // 
            this.txb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_email.Location = new System.Drawing.Point(246, 508);
            this.txb_email.Name = "txb_email";
            this.txb_email.Size = new System.Drawing.Size(960, 43);
            this.txb_email.TabIndex = 92;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 515);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 36);
            this.label3.TabIndex = 91;
            this.label3.Text = "Email: ";
            // 
            // dt_birth
            // 
            this.dt_birth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_birth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_birth.Location = new System.Drawing.Point(246, 271);
            this.dt_birth.Name = "dt_birth";
            this.dt_birth.Size = new System.Drawing.Size(364, 43);
            this.dt_birth.TabIndex = 90;
            // 
            // txb_phone
            // 
            this.txb_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_phone.Location = new System.Drawing.Point(246, 352);
            this.txb_phone.Name = "txb_phone";
            this.txb_phone.Size = new System.Drawing.Size(364, 43);
            this.txb_phone.TabIndex = 89;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(106, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 36);
            this.label7.TabIndex = 88;
            this.label7.Text = "Phone: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(96, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 36);
            this.label8.TabIndex = 87;
            this.label8.Text = "Gender: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(78, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 36);
            this.label9.TabIndex = 86;
            this.label9.Text = "Birthday: ";
            // 
            // txb_address
            // 
            this.txb_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_address.Location = new System.Drawing.Point(246, 429);
            this.txb_address.Name = "txb_address";
            this.txb_address.Size = new System.Drawing.Size(960, 43);
            this.txb_address.TabIndex = 85;
            // 
            // lb_address
            // 
            this.lb_address.AutoSize = true;
            this.lb_address.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_address.Location = new System.Drawing.Point(86, 437);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(133, 36);
            this.lb_address.TabIndex = 84;
            this.lb_address.Text = "Address: ";
            // 
            // txb_lastname
            // 
            this.txb_lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_lastname.Location = new System.Drawing.Point(246, 137);
            this.txb_lastname.Name = "txb_lastname";
            this.txb_lastname.Size = new System.Drawing.Size(364, 43);
            this.txb_lastname.TabIndex = 83;
            // 
            // lblastname
            // 
            this.lblastname.AutoSize = true;
            this.lblastname.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblastname.Location = new System.Drawing.Point(60, 145);
            this.lblastname.Name = "lblastname";
            this.lblastname.Size = new System.Drawing.Size(159, 36);
            this.lblastname.TabIndex = 82;
            this.lblastname.Text = "Last name: ";
            // 
            // txb_firstname
            // 
            this.txb_firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_firstname.Location = new System.Drawing.Point(246, 65);
            this.txb_firstname.Name = "txb_firstname";
            this.txb_firstname.Size = new System.Drawing.Size(364, 43);
            this.txb_firstname.TabIndex = 81;
            // 
            // ldfirstname
            // 
            this.ldfirstname.AutoSize = true;
            this.ldfirstname.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldfirstname.Location = new System.Drawing.Point(60, 71);
            this.ldfirstname.Name = "ldfirstname";
            this.ldfirstname.Size = new System.Drawing.Size(164, 36);
            this.ldfirstname.TabIndex = 80;
            this.ldfirstname.Text = "First name: ";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(240, 588);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(65, 36);
            this.lblRole.TabIndex = 79;
            this.lblRole.Text = "role";
            // 
            // lbrole
            // 
            this.lbrole.AutoSize = true;
            this.lbrole.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrole.Location = new System.Drawing.Point(123, 588);
            this.lbrole.Name = "lbrole";
            this.lbrole.Size = new System.Drawing.Size(92, 36);
            this.lbrole.TabIndex = 78;
            this.lbrole.Text = "Role: ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdGenderFemale);
            this.groupBox2.Controls.Add(this.rdGenderMale);
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.txb_firstname);
            this.groupBox2.Controls.Add(this.btnUpdateInfo);
            this.groupBox2.Controls.Add(this.dt_birth);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txb_email);
            this.groupBox2.Controls.Add(this.txb_lastname);
            this.groupBox2.Controls.Add(this.lblastname);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblRole);
            this.groupBox2.Controls.Add(this.ldfirstname);
            this.groupBox2.Controls.Add(this.txb_phone);
            this.groupBox2.Controls.Add(this.txb_address);
            this.groupBox2.Controls.Add(this.lb_address);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lbrole);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, -15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(2224, 1005);
            this.groupBox2.TabIndex = 79;
            this.groupBox2.TabStop = false;
            // 
            // inFoAccountView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "inFoAccountView";
            this.Size = new System.Drawing.Size(1600, 872);
            this.Load += new System.EventHandler(this.inFoAccountView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnUpdateInfo;
        private System.Windows.Forms.RadioButton rdGenderMale;
        private System.Windows.Forms.RadioButton rdGenderFemale;
        private System.Windows.Forms.TextBox txb_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dt_birth;
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
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lbrole;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
