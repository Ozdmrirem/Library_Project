namespace Library_Project
{
    partial class frmBooks
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
            this.tbxSearchBook = new System.Windows.Forms.TextBox();
            this.lblSearchBook = new System.Windows.Forms.Label();
            this.lblBooksName = new System.Windows.Forms.Label();
            this.tbxUpdateBooksName = new System.Windows.Forms.TextBox();
            this.lblPublishersName = new System.Windows.Forms.Label();
            this.tbxUpdatePublishersName = new System.Windows.Forms.TextBox();
            this.lblAuthorsName = new System.Windows.Forms.Label();
            this.tbxUpdateAuthorsName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbxInsertBook = new System.Windows.Forms.GroupBox();
            this.btnInsertBook = new System.Windows.Forms.Button();
            this.numStock = new System.Windows.Forms.NumericUpDown();
            this.numPageCount = new System.Windows.Forms.NumericUpDown();
            this.dtpReleasedDate = new System.Windows.Forms.DateTimePicker();
            this.cbxAuthorName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxPublisher = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxBookName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBooks)).BeginInit();
            this.gbxInsertBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPageCount)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwBooks
            // 
            this.dgwBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBooks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwBooks.Location = new System.Drawing.Point(0, 343);
            this.dgwBooks.Name = "dgwBooks";
            this.dgwBooks.RowHeadersWidth = 51;
            this.dgwBooks.RowTemplate.Height = 24;
            this.dgwBooks.Size = new System.Drawing.Size(991, 186);
            this.dgwBooks.TabIndex = 0;
            this.dgwBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwBooks_CellClick);
            // 
            // tbxSearchBook
            // 
            this.tbxSearchBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSearchBook.Location = new System.Drawing.Point(717, 307);
            this.tbxSearchBook.Name = "tbxSearchBook";
            this.tbxSearchBook.Size = new System.Drawing.Size(249, 30);
            this.tbxSearchBook.TabIndex = 1;
            this.tbxSearchBook.TextChanged += new System.EventHandler(this.tbxSearchBook_TextChanged);
            // 
            // lblSearchBook
            // 
            this.lblSearchBook.AutoSize = true;
            this.lblSearchBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSearchBook.Location = new System.Drawing.Point(607, 310);
            this.lblSearchBook.Name = "lblSearchBook";
            this.lblSearchBook.Size = new System.Drawing.Size(104, 25);
            this.lblSearchBook.TabIndex = 2;
            this.lblSearchBook.Text = "Kitap Ara :";
            // 
            // lblBooksName
            // 
            this.lblBooksName.AutoSize = true;
            this.lblBooksName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBooksName.Location = new System.Drawing.Point(12, 24);
            this.lblBooksName.Name = "lblBooksName";
            this.lblBooksName.Size = new System.Drawing.Size(102, 25);
            this.lblBooksName.TabIndex = 4;
            this.lblBooksName.Text = "Kitap Adı :";
            // 
            // tbxUpdateBooksName
            // 
            this.tbxUpdateBooksName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUpdateBooksName.Location = new System.Drawing.Point(134, 21);
            this.tbxUpdateBooksName.Name = "tbxUpdateBooksName";
            this.tbxUpdateBooksName.Size = new System.Drawing.Size(249, 30);
            this.tbxUpdateBooksName.TabIndex = 3;
            // 
            // lblPublishersName
            // 
            this.lblPublishersName.AutoSize = true;
            this.lblPublishersName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPublishersName.Location = new System.Drawing.Point(17, 96);
            this.lblPublishersName.Name = "lblPublishersName";
            this.lblPublishersName.Size = new System.Drawing.Size(97, 25);
            this.lblPublishersName.TabIndex = 6;
            this.lblPublishersName.Text = "Yayınevi :";
            // 
            // tbxUpdatePublishersName
            // 
            this.tbxUpdatePublishersName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUpdatePublishersName.Location = new System.Drawing.Point(134, 93);
            this.tbxUpdatePublishersName.Name = "tbxUpdatePublishersName";
            this.tbxUpdatePublishersName.Size = new System.Drawing.Size(249, 30);
            this.tbxUpdatePublishersName.TabIndex = 5;
            // 
            // lblAuthorsName
            // 
            this.lblAuthorsName.AutoSize = true;
            this.lblAuthorsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAuthorsName.Location = new System.Drawing.Point(6, 60);
            this.lblAuthorsName.Name = "lblAuthorsName";
            this.lblAuthorsName.Size = new System.Drawing.Size(108, 25);
            this.lblAuthorsName.TabIndex = 8;
            this.lblAuthorsName.Text = "Yazar Adı :";
            // 
            // tbxUpdateAuthorsName
            // 
            this.tbxUpdateAuthorsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUpdateAuthorsName.Location = new System.Drawing.Point(134, 57);
            this.tbxUpdateAuthorsName.Name = "tbxUpdateAuthorsName";
            this.tbxUpdateAuthorsName.Size = new System.Drawing.Size(249, 30);
            this.tbxUpdateAuthorsName.TabIndex = 7;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Location = new System.Drawing.Point(178, 158);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(205, 34);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Location = new System.Drawing.Point(178, 207);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(205, 34);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbxInsertBook
            // 
            this.gbxInsertBook.Controls.Add(this.btnInsertBook);
            this.gbxInsertBook.Controls.Add(this.numStock);
            this.gbxInsertBook.Controls.Add(this.numPageCount);
            this.gbxInsertBook.Controls.Add(this.dtpReleasedDate);
            this.gbxInsertBook.Controls.Add(this.cbxAuthorName);
            this.gbxInsertBook.Controls.Add(this.label4);
            this.gbxInsertBook.Controls.Add(this.label5);
            this.gbxInsertBook.Controls.Add(this.label6);
            this.gbxInsertBook.Controls.Add(this.tbxPublisher);
            this.gbxInsertBook.Controls.Add(this.label3);
            this.gbxInsertBook.Controls.Add(this.label2);
            this.gbxInsertBook.Controls.Add(this.tbxBookName);
            this.gbxInsertBook.Controls.Add(this.label1);
            this.gbxInsertBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxInsertBook.Location = new System.Drawing.Point(413, 6);
            this.gbxInsertBook.Name = "gbxInsertBook";
            this.gbxInsertBook.Size = new System.Drawing.Size(553, 284);
            this.gbxInsertBook.TabIndex = 11;
            this.gbxInsertBook.TabStop = false;
            this.gbxInsertBook.Text = "Yeni Kitap Kaydı";
            // 
            // btnInsertBook
            // 
            this.btnInsertBook.Location = new System.Drawing.Point(304, 225);
            this.btnInsertBook.Name = "btnInsertBook";
            this.btnInsertBook.Size = new System.Drawing.Size(179, 42);
            this.btnInsertBook.TabIndex = 12;
            this.btnInsertBook.Text = "Kaydı Ekle";
            this.btnInsertBook.UseVisualStyleBackColor = true;
            this.btnInsertBook.Click += new System.EventHandler(this.btnInsertBook_Click);
            // 
            // numStock
            // 
            this.numStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numStock.Location = new System.Drawing.Point(209, 192);
            this.numStock.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numStock.Name = "numStock";
            this.numStock.Size = new System.Drawing.Size(315, 27);
            this.numStock.TabIndex = 31;
            // 
            // numPageCount
            // 
            this.numPageCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numPageCount.Location = new System.Drawing.Point(209, 159);
            this.numPageCount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numPageCount.Name = "numPageCount";
            this.numPageCount.Size = new System.Drawing.Size(315, 27);
            this.numPageCount.TabIndex = 30;
            // 
            // dtpReleasedDate
            // 
            this.dtpReleasedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpReleasedDate.Location = new System.Drawing.Point(209, 126);
            this.dtpReleasedDate.Name = "dtpReleasedDate";
            this.dtpReleasedDate.Size = new System.Drawing.Size(315, 27);
            this.dtpReleasedDate.TabIndex = 29;
            // 
            // cbxAuthorName
            // 
            this.cbxAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxAuthorName.FormattingEnabled = true;
            this.cbxAuthorName.Location = new System.Drawing.Point(209, 59);
            this.cbxAuthorName.Name = "cbxAuthorName";
            this.cbxAuthorName.Size = new System.Drawing.Size(315, 28);
            this.cbxAuthorName.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(151, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Stok :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(92, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Sayfa Sayısı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(97, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Yayın Tarihi :";
            // 
            // tbxPublisher
            // 
            this.tbxPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxPublisher.Location = new System.Drawing.Point(209, 93);
            this.tbxPublisher.Name = "tbxPublisher";
            this.tbxPublisher.Size = new System.Drawing.Size(315, 27);
            this.tbxPublisher.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(123, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Yayınevi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(141, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Yazar :";
            // 
            // tbxBookName
            // 
            this.tbxBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxBookName.Location = new System.Drawing.Point(209, 22);
            this.tbxBookName.Name = "tbxBookName";
            this.tbxBookName.Size = new System.Drawing.Size(315, 27);
            this.tbxBookName.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(146, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Kitap :";
            // 
            // frmBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 529);
            this.Controls.Add(this.gbxInsertBook);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblAuthorsName);
            this.Controls.Add(this.tbxUpdateAuthorsName);
            this.Controls.Add(this.lblPublishersName);
            this.Controls.Add(this.tbxUpdatePublishersName);
            this.Controls.Add(this.lblBooksName);
            this.Controls.Add(this.tbxUpdateBooksName);
            this.Controls.Add(this.lblSearchBook);
            this.Controls.Add(this.tbxSearchBook);
            this.Controls.Add(this.dgwBooks);
            this.Name = "frmBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitaplar";
            this.Load += new System.EventHandler(this.frmBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBooks)).EndInit();
            this.gbxInsertBook.ResumeLayout(false);
            this.gbxInsertBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPageCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwBooks;
        private System.Windows.Forms.TextBox tbxSearchBook;
        private System.Windows.Forms.Label lblSearchBook;
        private System.Windows.Forms.Label lblBooksName;
        private System.Windows.Forms.TextBox tbxUpdateBooksName;
        private System.Windows.Forms.Label lblPublishersName;
        private System.Windows.Forms.TextBox tbxUpdatePublishersName;
        private System.Windows.Forms.Label lblAuthorsName;
        private System.Windows.Forms.TextBox tbxUpdateAuthorsName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbxInsertBook;
        private System.Windows.Forms.Button btnInsertBook;
        private System.Windows.Forms.NumericUpDown numStock;
        private System.Windows.Forms.NumericUpDown numPageCount;
        private System.Windows.Forms.DateTimePicker dtpReleasedDate;
        private System.Windows.Forms.ComboBox cbxAuthorName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxPublisher;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxBookName;
        private System.Windows.Forms.Label label1;
    }
}