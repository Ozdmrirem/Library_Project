namespace Library_Project
{
    partial class frmMembers
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
            this.gbxInsertMember = new System.Windows.Forms.GroupBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
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
            this.gbxInsertMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxInsertMember
            // 
            this.gbxInsertMember.Controls.Add(this.tbxLastName);
            this.gbxInsertMember.Controls.Add(this.btnInsert);
            this.gbxInsertMember.Controls.Add(this.chkSuperAdmin);
            this.gbxInsertMember.Controls.Add(this.chkAdmin);
            this.gbxInsertMember.Controls.Add(this.chkMember);
            this.gbxInsertMember.Controls.Add(this.rbMan);
            this.gbxInsertMember.Controls.Add(this.rbWoman);
            this.gbxInsertMember.Controls.Add(this.dtpBirthDate);
            this.gbxInsertMember.Controls.Add(this.label6);
            this.gbxInsertMember.Controls.Add(this.tbxIdentityNumber);
            this.gbxInsertMember.Controls.Add(this.label3);
            this.gbxInsertMember.Controls.Add(this.label2);
            this.gbxInsertMember.Controls.Add(this.tbxFirstName);
            this.gbxInsertMember.Controls.Add(this.label1);
            this.gbxInsertMember.Location = new System.Drawing.Point(304, 12);
            this.gbxInsertMember.Name = "gbxInsertMember";
            this.gbxInsertMember.Size = new System.Drawing.Size(452, 426);
            this.gbxInsertMember.TabIndex = 0;
            this.gbxInsertMember.TabStop = false;
            this.gbxInsertMember.Text = "Üye Ekle";
            // 
            // tbxLastName
            // 
            this.tbxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxLastName.Location = new System.Drawing.Point(161, 71);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(260, 27);
            this.tbxLastName.TabIndex = 32;
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInsert.Location = new System.Drawing.Point(314, 356);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(107, 33);
            this.btnInsert.TabIndex = 31;
            this.btnInsert.Text = "Kaydet";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // chkSuperAdmin
            // 
            this.chkSuperAdmin.AutoSize = true;
            this.chkSuperAdmin.Location = new System.Drawing.Point(161, 314);
            this.chkSuperAdmin.Name = "chkSuperAdmin";
            this.chkSuperAdmin.Size = new System.Drawing.Size(77, 20);
            this.chkSuperAdmin.TabIndex = 30;
            this.chkSuperAdmin.Text = "Yönetici";
            this.chkSuperAdmin.UseVisualStyleBackColor = true;
            // 
            // chkAdmin
            // 
            this.chkAdmin.AutoSize = true;
            this.chkAdmin.Location = new System.Drawing.Point(161, 288);
            this.chkAdmin.Name = "chkAdmin";
            this.chkAdmin.Size = new System.Drawing.Size(91, 20);
            this.chkAdmin.TabIndex = 29;
            this.chkAdmin.Text = "Moderatör";
            this.chkAdmin.UseVisualStyleBackColor = true;
            // 
            // chkMember
            // 
            this.chkMember.AutoSize = true;
            this.chkMember.Location = new System.Drawing.Point(161, 262);
            this.chkMember.Name = "chkMember";
            this.chkMember.Size = new System.Drawing.Size(101, 20);
            this.chkMember.TabIndex = 28;
            this.chkMember.Text = "Normal Üye";
            this.chkMember.UseVisualStyleBackColor = true;
            // 
            // rbMan
            // 
            this.rbMan.AutoSize = true;
            this.rbMan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbMan.Location = new System.Drawing.Point(316, 199);
            this.rbMan.Name = "rbMan";
            this.rbMan.Size = new System.Drawing.Size(72, 24);
            this.rbMan.TabIndex = 27;
            this.rbMan.TabStop = true;
            this.rbMan.Text = "Erkek";
            this.rbMan.UseVisualStyleBackColor = true;
            // 
            // rbWoman
            // 
            this.rbWoman.AutoSize = true;
            this.rbWoman.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbWoman.Location = new System.Drawing.Point(164, 199);
            this.rbWoman.Name = "rbWoman";
            this.rbWoman.Size = new System.Drawing.Size(72, 24);
            this.rbWoman.TabIndex = 26;
            this.rbWoman.TabStop = true;
            this.rbWoman.Text = "Kadın";
            this.rbWoman.UseVisualStyleBackColor = true;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpBirthDate.Location = new System.Drawing.Point(161, 157);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(260, 27);
            this.dtpBirthDate.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(26, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Doğum Tarihi :";
            // 
            // tbxIdentityNumber
            // 
            this.tbxIdentityNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxIdentityNumber.Location = new System.Drawing.Point(161, 113);
            this.tbxIdentityNumber.Name = "tbxIdentityNumber";
            this.tbxIdentityNumber.Size = new System.Drawing.Size(260, 27);
            this.tbxIdentityNumber.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(79, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "TC No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(81, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Soyad :";
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxFirstName.Location = new System.Drawing.Point(161, 29);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(260, 27);
            this.tbxFirstName.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(107, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ad :";
            // 
            // frmMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 450);
            this.Controls.Add(this.gbxInsertMember);
            this.Name = "frmMembers";
            this.Text = "frmMembers";
            this.gbxInsertMember.ResumeLayout(false);
            this.gbxInsertMember.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxInsertMember;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxIdentityNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbMan;
        private System.Windows.Forms.RadioButton rbWoman;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.CheckBox chkSuperAdmin;
        private System.Windows.Forms.CheckBox chkAdmin;
        private System.Windows.Forms.CheckBox chkMember;
        private System.Windows.Forms.TextBox tbxLastName;
    }
}