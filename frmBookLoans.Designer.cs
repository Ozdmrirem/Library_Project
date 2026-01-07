namespace Library_Project
{
    partial class frmBookLoans
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
            this.dgwBooks = new System.Windows.Forms.DataGridView();
            this.dgwMembers = new System.Windows.Forms.DataGridView();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.gbxMembers = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.tbxBirthDate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxIdentityNumber = new System.Windows.Forms.TextBox();
            this.gbxBooks = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tbxAuthorName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxBookName = new System.Windows.Forms.TextBox();
            this.tbxStock = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxPublisherName = new System.Windows.Forms.TextBox();
            this.tbxPageCount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxSearchBook = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbxSearchMember = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.gbxInformation = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnProccessDone = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMembers)).BeginInit();
            this.gbxMembers.SuspendLayout();
            this.gbxBooks.SuspendLayout();
            this.gbxInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwBooks
            // 
            this.dgwBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBooks.Location = new System.Drawing.Point(12, 361);
            this.dgwBooks.Name = "dgwBooks";
            this.dgwBooks.RowHeadersWidth = 51;
            this.dgwBooks.RowTemplate.Height = 24;
            this.dgwBooks.Size = new System.Drawing.Size(497, 203);
            this.dgwBooks.TabIndex = 0;
            this.dgwBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwBooks_CellClick);
            // 
            // dgwMembers
            // 
            this.dgwMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMembers.Location = new System.Drawing.Point(531, 361);
            this.dgwMembers.Name = "dgwMembers";
            this.dgwMembers.RowHeadersWidth = 51;
            this.dgwMembers.RowTemplate.Height = 24;
            this.dgwMembers.Size = new System.Drawing.Size(517, 203);
            this.dgwMembers.TabIndex = 1;
            this.dgwMembers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMembers_CellClick);
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpDueDate.Location = new System.Drawing.Point(120, 273);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(260, 27);
            this.dtpDueDate.TabIndex = 2;
            // 
            // gbxMembers
            // 
            this.gbxMembers.Controls.Add(this.label9);
            this.gbxMembers.Controls.Add(this.btnCancel);
            this.gbxMembers.Controls.Add(this.btnHistory);
            this.gbxMembers.Controls.Add(this.tbxFirstName);
            this.gbxMembers.Controls.Add(this.tbxBirthDate);
            this.gbxMembers.Controls.Add(this.label8);
            this.gbxMembers.Controls.Add(this.label10);
            this.gbxMembers.Controls.Add(this.label7);
            this.gbxMembers.Controls.Add(this.tbxLastName);
            this.gbxMembers.Controls.Add(this.tbxIdentityNumber);
            this.gbxMembers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gbxMembers.Location = new System.Drawing.Point(399, 12);
            this.gbxMembers.Name = "gbxMembers";
            this.gbxMembers.Size = new System.Drawing.Size(436, 288);
            this.gbxMembers.TabIndex = 49;
            this.gbxMembers.TabStop = false;
            this.gbxMembers.Text = "Üye Bilgileri";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(80, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 18);
            this.label9.TabIndex = 38;
            this.label9.Text = "Ad :";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancel.Location = new System.Drawing.Point(136, 237);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(260, 32);
            this.btnCancel.TabIndex = 47;
            this.btnCancel.Text = "İptal Et";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnHistory
            // 
            this.btnHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHistory.Location = new System.Drawing.Point(136, 180);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(260, 49);
            this.btnHistory.TabIndex = 46;
            this.btnHistory.Text = "Geçmiş İşlemler";
            this.btnHistory.UseVisualStyleBackColor = true;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxFirstName.Location = new System.Drawing.Point(136, 34);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(260, 24);
            this.tbxFirstName.TabIndex = 39;
            // 
            // tbxBirthDate
            // 
            this.tbxBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxBirthDate.Location = new System.Drawing.Point(136, 137);
            this.tbxBirthDate.Name = "tbxBirthDate";
            this.tbxBirthDate.Size = new System.Drawing.Size(260, 24);
            this.tbxBirthDate.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(55, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 18);
            this.label8.TabIndex = 40;
            this.label8.Text = "Soyad :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(8, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 18);
            this.label10.TabIndex = 44;
            this.label10.Text = "Doğum Tarihi :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(53, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 18);
            this.label7.TabIndex = 41;
            this.label7.Text = "TC No :";
            // 
            // tbxLastName
            // 
            this.tbxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxLastName.Location = new System.Drawing.Point(136, 66);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(260, 24);
            this.tbxLastName.TabIndex = 43;
            // 
            // tbxIdentityNumber
            // 
            this.tbxIdentityNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxIdentityNumber.Location = new System.Drawing.Point(136, 101);
            this.tbxIdentityNumber.Name = "tbxIdentityNumber";
            this.tbxIdentityNumber.Size = new System.Drawing.Size(260, 24);
            this.tbxIdentityNumber.TabIndex = 42;
            // 
            // gbxBooks
            // 
            this.gbxBooks.Controls.Add(this.label20);
            this.gbxBooks.Controls.Add(this.tbxAuthorName);
            this.gbxBooks.Controls.Add(this.label1);
            this.gbxBooks.Controls.Add(this.tbxBookName);
            this.gbxBooks.Controls.Add(this.tbxStock);
            this.gbxBooks.Controls.Add(this.label2);
            this.gbxBooks.Controls.Add(this.label3);
            this.gbxBooks.Controls.Add(this.label4);
            this.gbxBooks.Controls.Add(this.tbxPublisherName);
            this.gbxBooks.Controls.Add(this.tbxPageCount);
            this.gbxBooks.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gbxBooks.Location = new System.Drawing.Point(16, 12);
            this.gbxBooks.Name = "gbxBooks";
            this.gbxBooks.Size = new System.Drawing.Size(364, 246);
            this.gbxBooks.TabIndex = 50;
            this.gbxBooks.TabStop = false;
            this.gbxBooks.Text = "Kitap Bilgileri";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(43, 77);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(54, 18);
            this.label20.TabIndex = 46;
            this.label20.Text = "Yazar :";
            // 
            // tbxAuthorName
            // 
            this.tbxAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxAuthorName.Location = new System.Drawing.Point(104, 74);
            this.tbxAuthorName.Name = "tbxAuthorName";
            this.tbxAuthorName.Size = new System.Drawing.Size(236, 24);
            this.tbxAuthorName.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(48, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 38;
            this.label1.Text = "Kitap :";
            // 
            // tbxBookName
            // 
            this.tbxBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxBookName.Location = new System.Drawing.Point(104, 37);
            this.tbxBookName.Name = "tbxBookName";
            this.tbxBookName.Size = new System.Drawing.Size(236, 24);
            this.tbxBookName.TabIndex = 39;
            // 
            // tbxStock
            // 
            this.tbxStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxStock.Location = new System.Drawing.Point(104, 184);
            this.tbxStock.Name = "tbxStock";
            this.tbxStock.Size = new System.Drawing.Size(236, 24);
            this.tbxStock.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(28, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 40;
            this.label2.Text = "Yayınevi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(50, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 44;
            this.label3.Text = "Stok :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(1, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 41;
            this.label4.Text = "Sayfa Sayısı :";
            // 
            // tbxPublisherName
            // 
            this.tbxPublisherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxPublisherName.Location = new System.Drawing.Point(104, 112);
            this.tbxPublisherName.Name = "tbxPublisherName";
            this.tbxPublisherName.Size = new System.Drawing.Size(236, 24);
            this.tbxPublisherName.TabIndex = 43;
            // 
            // tbxPageCount
            // 
            this.tbxPageCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxPageCount.Location = new System.Drawing.Point(104, 148);
            this.tbxPageCount.Name = "tbxPageCount";
            this.tbxPageCount.Size = new System.Drawing.Size(236, 24);
            this.tbxPageCount.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(16, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 51;
            this.label5.Text = "İade Tarihi :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(8, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 20);
            this.label6.TabIndex = 52;
            this.label6.Text = "KİTAP BİLGİLERİ";
            // 
            // tbxSearchBook
            // 
            this.tbxSearchBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSearchBook.Location = new System.Drawing.Point(267, 326);
            this.tbxSearchBook.Name = "tbxSearchBook";
            this.tbxSearchBook.Size = new System.Drawing.Size(242, 24);
            this.tbxSearchBook.TabIndex = 54;
            this.tbxSearchBook.TextChanged += new System.EventHandler(this.tbxSearchBook_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(186, 329);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 18);
            this.label11.TabIndex = 53;
            this.label11.Text = "Kitap Ara :";
            // 
            // tbxSearchMember
            // 
            this.tbxSearchMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSearchMember.Location = new System.Drawing.Point(776, 327);
            this.tbxSearchMember.Name = "tbxSearchMember";
            this.tbxSearchMember.Size = new System.Drawing.Size(272, 24);
            this.tbxSearchMember.TabIndex = 57;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(702, 330);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 18);
            this.label12.TabIndex = 56;
            this.label12.Text = "Üye Ara :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(531, 329);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(140, 20);
            this.label13.TabIndex = 55;
            this.label13.Text = "ÜYE BİLGİLERİ";
            // 
            // gbxInformation
            // 
            this.gbxInformation.Controls.Add(this.label19);
            this.gbxInformation.Controls.Add(this.label18);
            this.gbxInformation.Controls.Add(this.label17);
            this.gbxInformation.Controls.Add(this.label16);
            this.gbxInformation.Controls.Add(this.label15);
            this.gbxInformation.Controls.Add(this.label14);
            this.gbxInformation.Location = new System.Drawing.Point(861, 12);
            this.gbxInformation.Name = "gbxInformation";
            this.gbxInformation.Size = new System.Drawing.Size(187, 246);
            this.gbxInformation.TabIndex = 58;
            this.gbxInformation.TabStop = false;
            this.gbxInformation.Text = "Bilgi Kutusu";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 219);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(122, 16);
            this.label19.TabIndex = 5;
            this.label19.Text = "Toplam Üye Sayısı";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 180);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(182, 16);
            this.label18.TabIndex = 4;
            this.label18.Text = "Bugüne Kadar Kiralanan Adet";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 140);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(144, 16);
            this.label17.TabIndex = 3;
            this.label17.Text = "Anlık Kiralıktaki Kitaplar";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 104);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 16);
            this.label16.TabIndex = 2;
            this.label16.Text = "Güncel Fiyatlar";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 70);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 16);
            this.label15.TabIndex = 1;
            this.label15.Text = "Saat";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "Tarih";
            // 
            // btnProccessDone
            // 
            this.btnProccessDone.BackColor = System.Drawing.Color.Chartreuse;
            this.btnProccessDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProccessDone.Location = new System.Drawing.Point(861, 273);
            this.btnProccessDone.Name = "btnProccessDone";
            this.btnProccessDone.Size = new System.Drawing.Size(187, 43);
            this.btnProccessDone.TabIndex = 59;
            this.btnProccessDone.Text = "Tamamla";
            this.btnProccessDone.UseVisualStyleBackColor = false;
            this.btnProccessDone.Click += new System.EventHandler(this.btnProccessDone_Click);
            // 
            // frmBookLoans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 696);
            this.Controls.Add(this.btnProccessDone);
            this.Controls.Add(this.gbxInformation);
            this.Controls.Add(this.tbxSearchMember);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbxSearchBook);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gbxBooks);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.dgwMembers);
            this.Controls.Add(this.dgwBooks);
            this.Controls.Add(this.gbxMembers);
            this.Name = "frmBookLoans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Kirala";
            this.Load += new System.EventHandler(this.frmBookLoans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMembers)).EndInit();
            this.gbxMembers.ResumeLayout(false);
            this.gbxMembers.PerformLayout();
            this.gbxBooks.ResumeLayout(false);
            this.gbxBooks.PerformLayout();
            this.gbxInformation.ResumeLayout(false);
            this.gbxInformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwBooks;
        private System.Windows.Forms.DataGridView dgwMembers;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.GroupBox gbxMembers;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.TextBox tbxBirthDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxIdentityNumber;
        private System.Windows.Forms.GroupBox gbxBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxBookName;
        private System.Windows.Forms.TextBox tbxStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxPublisherName;
        private System.Windows.Forms.TextBox tbxPageCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxSearchBook;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbxSearchMember;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox gbxInformation;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbxAuthorName;
        private System.Windows.Forms.Button btnProccessDone;
    }
}