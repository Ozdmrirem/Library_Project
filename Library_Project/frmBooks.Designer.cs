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
            this.tbxBooksName = new System.Windows.Forms.TextBox();
            this.lblPublishersName = new System.Windows.Forms.Label();
            this.tbxPublishersName = new System.Windows.Forms.TextBox();
            this.lblAuthorsName = new System.Windows.Forms.Label();
            this.tbxAuthorsName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwBooks
            // 
            this.dgwBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBooks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwBooks.Location = new System.Drawing.Point(0, 284);
            this.dgwBooks.Name = "dgwBooks";
            this.dgwBooks.RowHeadersWidth = 51;
            this.dgwBooks.RowTemplate.Height = 24;
            this.dgwBooks.Size = new System.Drawing.Size(895, 218);
            this.dgwBooks.TabIndex = 0;
            this.dgwBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwBooks_CellClick);
            // 
            // tbxSearchBook
            // 
            this.tbxSearchBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSearchBook.Location = new System.Drawing.Point(634, 248);
            this.tbxSearchBook.Name = "tbxSearchBook";
            this.tbxSearchBook.Size = new System.Drawing.Size(249, 30);
            this.tbxSearchBook.TabIndex = 1;
            this.tbxSearchBook.TextChanged += new System.EventHandler(this.tbxSearchBook_TextChanged);
            // 
            // lblSearchBook
            // 
            this.lblSearchBook.AutoSize = true;
            this.lblSearchBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSearchBook.Location = new System.Drawing.Point(512, 251);
            this.lblSearchBook.Name = "lblSearchBook";
            this.lblSearchBook.Size = new System.Drawing.Size(104, 25);
            this.lblSearchBook.TabIndex = 2;
            this.lblSearchBook.Text = "Kitap Ara :";
            // 
            // lblBooksName
            // 
            this.lblBooksName.AutoSize = true;
            this.lblBooksName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBooksName.Location = new System.Drawing.Point(12, 9);
            this.lblBooksName.Name = "lblBooksName";
            this.lblBooksName.Size = new System.Drawing.Size(102, 25);
            this.lblBooksName.TabIndex = 4;
            this.lblBooksName.Text = "Kitap Adı :";
            // 
            // tbxBooksName
            // 
            this.tbxBooksName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxBooksName.Location = new System.Drawing.Point(134, 6);
            this.tbxBooksName.Name = "tbxBooksName";
            this.tbxBooksName.Size = new System.Drawing.Size(249, 30);
            this.tbxBooksName.TabIndex = 3;
            // 
            // lblPublishersName
            // 
            this.lblPublishersName.AutoSize = true;
            this.lblPublishersName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPublishersName.Location = new System.Drawing.Point(17, 81);
            this.lblPublishersName.Name = "lblPublishersName";
            this.lblPublishersName.Size = new System.Drawing.Size(97, 25);
            this.lblPublishersName.TabIndex = 6;
            this.lblPublishersName.Text = "Yayınevi :";
            // 
            // tbxPublishersName
            // 
            this.tbxPublishersName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxPublishersName.Location = new System.Drawing.Point(134, 78);
            this.tbxPublishersName.Name = "tbxPublishersName";
            this.tbxPublishersName.Size = new System.Drawing.Size(249, 30);
            this.tbxPublishersName.TabIndex = 5;
            // 
            // lblAuthorsName
            // 
            this.lblAuthorsName.AutoSize = true;
            this.lblAuthorsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAuthorsName.Location = new System.Drawing.Point(6, 45);
            this.lblAuthorsName.Name = "lblAuthorsName";
            this.lblAuthorsName.Size = new System.Drawing.Size(108, 25);
            this.lblAuthorsName.TabIndex = 8;
            this.lblAuthorsName.Text = "Yazar Adı :";
            // 
            // tbxAuthorsName
            // 
            this.tbxAuthorsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxAuthorsName.Location = new System.Drawing.Point(134, 42);
            this.tbxAuthorsName.Name = "tbxAuthorsName";
            this.tbxAuthorsName.Size = new System.Drawing.Size(249, 30);
            this.tbxAuthorsName.TabIndex = 7;
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
            // frmBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 502);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblAuthorsName);
            this.Controls.Add(this.tbxAuthorsName);
            this.Controls.Add(this.lblPublishersName);
            this.Controls.Add(this.tbxPublishersName);
            this.Controls.Add(this.lblBooksName);
            this.Controls.Add(this.tbxBooksName);
            this.Controls.Add(this.lblSearchBook);
            this.Controls.Add(this.tbxSearchBook);
            this.Controls.Add(this.dgwBooks);
            this.Name = "frmBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitaplar";
            this.Load += new System.EventHandler(this.frmBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwBooks;
        private System.Windows.Forms.TextBox tbxSearchBook;
        private System.Windows.Forms.Label lblSearchBook;
        private System.Windows.Forms.Label lblBooksName;
        private System.Windows.Forms.TextBox tbxBooksName;
        private System.Windows.Forms.Label lblPublishersName;
        private System.Windows.Forms.TextBox tbxPublishersName;
        private System.Windows.Forms.Label lblAuthorsName;
        private System.Windows.Forms.TextBox tbxAuthorsName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}