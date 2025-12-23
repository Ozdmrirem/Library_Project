namespace Library_Project
{
    partial class frmUpdateMembers
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
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxUserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.chkSuperAdmin = new System.Windows.Forms.CheckBox();
            this.chkAdmin = new System.Windows.Forms.CheckBox();
            this.chkMember = new System.Windows.Forms.CheckBox();
            this.rbMan = new System.Windows.Forms.RadioButton();
            this.rbWoman = new System.Windows.Forms.RadioButton();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxIdentityNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxPassword
            // 
            this.tbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxPassword.Location = new System.Drawing.Point(155, 225);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(260, 24);
            this.tbxPassword.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(86, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 53;
            this.label4.Text = "Şifre :";
            // 
            // tbxUserName
            // 
            this.tbxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUserName.Location = new System.Drawing.Point(155, 189);
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.Size = new System.Drawing.Size(260, 24);
            this.tbxUserName.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(38, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 18);
            this.label5.TabIndex = 51;
            this.label5.Text = "Kullanıcı Adı :";
            // 
            // tbxLastName
            // 
            this.tbxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxLastName.Location = new System.Drawing.Point(155, 49);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(260, 24);
            this.tbxLastName.TabIndex = 50;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Location = new System.Drawing.Point(155, 392);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(260, 33);
            this.btnUpdate.TabIndex = 49;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // chkSuperAdmin
            // 
            this.chkSuperAdmin.AutoSize = true;
            this.chkSuperAdmin.Location = new System.Drawing.Point(155, 337);
            this.chkSuperAdmin.Name = "chkSuperAdmin";
            this.chkSuperAdmin.Size = new System.Drawing.Size(77, 20);
            this.chkSuperAdmin.TabIndex = 48;
            this.chkSuperAdmin.Text = "Yönetici";
            this.chkSuperAdmin.UseVisualStyleBackColor = true;
            // 
            // chkAdmin
            // 
            this.chkAdmin.AutoSize = true;
            this.chkAdmin.Location = new System.Drawing.Point(155, 311);
            this.chkAdmin.Name = "chkAdmin";
            this.chkAdmin.Size = new System.Drawing.Size(91, 20);
            this.chkAdmin.TabIndex = 47;
            this.chkAdmin.Text = "Moderatör";
            this.chkAdmin.UseVisualStyleBackColor = true;
            // 
            // chkMember
            // 
            this.chkMember.AutoSize = true;
            this.chkMember.Location = new System.Drawing.Point(155, 285);
            this.chkMember.Name = "chkMember";
            this.chkMember.Size = new System.Drawing.Size(101, 20);
            this.chkMember.TabIndex = 46;
            this.chkMember.Text = "Normal Üye";
            this.chkMember.UseVisualStyleBackColor = true;
            // 
            // rbMan
            // 
            this.rbMan.AutoSize = true;
            this.rbMan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbMan.Location = new System.Drawing.Point(316, 156);
            this.rbMan.Name = "rbMan";
            this.rbMan.Size = new System.Drawing.Size(68, 22);
            this.rbMan.TabIndex = 45;
            this.rbMan.TabStop = true;
            this.rbMan.Text = "Erkek";
            this.rbMan.UseVisualStyleBackColor = true;
            // 
            // rbWoman
            // 
            this.rbWoman.AutoSize = true;
            this.rbWoman.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbWoman.Location = new System.Drawing.Point(158, 156);
            this.rbWoman.Name = "rbWoman";
            this.rbWoman.Size = new System.Drawing.Size(66, 22);
            this.rbWoman.TabIndex = 44;
            this.rbWoman.TabStop = true;
            this.rbWoman.Text = "Kadın";
            this.rbWoman.UseVisualStyleBackColor = true;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpBirthDate.Location = new System.Drawing.Point(155, 120);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(260, 24);
            this.dtpBirthDate.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(27, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 18);
            this.label6.TabIndex = 42;
            this.label6.Text = "Doğum Tarihi :";
            // 
            // tbxIdentityNumber
            // 
            this.tbxIdentityNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxIdentityNumber.Location = new System.Drawing.Point(155, 84);
            this.tbxIdentityNumber.Name = "tbxIdentityNumber";
            this.tbxIdentityNumber.Size = new System.Drawing.Size(260, 24);
            this.tbxIdentityNumber.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(72, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 40;
            this.label3.Text = "TC No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(74, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 39;
            this.label2.Text = "Soyad :";
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxFirstName.Location = new System.Drawing.Point(155, 17);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(260, 24);
            this.tbxFirstName.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(99, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 18);
            this.label1.TabIndex = 37;
            this.label1.Text = "Ad :";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancel.Location = new System.Drawing.Point(155, 431);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(260, 33);
            this.btnCancel.TabIndex = 55;
            this.btnCancel.Text = "İptal Et";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // frmUpdateMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 494);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxUserName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.chkSuperAdmin);
            this.Controls.Add(this.chkAdmin);
            this.Controls.Add(this.chkMember);
            this.Controls.Add(this.rbMan);
            this.Controls.Add(this.rbWoman);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxIdentityNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxFirstName);
            this.Controls.Add(this.label1);
            this.Name = "frmUpdateMembers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üye Güncelle";
            this.Load += new System.EventHandler(this.frmUpdateMembers_Load);
            this.Click += new System.EventHandler(this.frmUpdateMembers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxUserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.CheckBox chkSuperAdmin;
        private System.Windows.Forms.CheckBox chkAdmin;
        private System.Windows.Forms.CheckBox chkMember;
        private System.Windows.Forms.RadioButton rbMan;
        private System.Windows.Forms.RadioButton rbWoman;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxIdentityNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
    }
}