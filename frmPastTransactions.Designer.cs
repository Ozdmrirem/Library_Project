namespace Library_Project
{
    partial class frmPastTransactions
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
            this.dgwPastTransactions = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPastTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwPastTransactions
            // 
            this.dgwPastTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPastTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwPastTransactions.Location = new System.Drawing.Point(0, 0);
            this.dgwPastTransactions.Name = "dgwPastTransactions";
            this.dgwPastTransactions.RowHeadersWidth = 51;
            this.dgwPastTransactions.RowTemplate.Height = 24;
            this.dgwPastTransactions.Size = new System.Drawing.Size(800, 450);
            this.dgwPastTransactions.TabIndex = 0;
            // 
            // frmPastTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgwPastTransactions);
            this.Name = "frmPastTransactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geçmiş İşlemler";
            this.Load += new System.EventHandler(this.frmPastTransactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPastTransactions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwPastTransactions;
    }
}