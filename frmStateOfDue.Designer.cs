namespace Library_Project
{
    partial class frmStateOfDue
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
            System.Windows.Forms.GroupBox gbxInformation;
            this.dgwCompletedReturns = new System.Windows.Forms.DataGridView();
            this.dgwNotCompletedReturns = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxSearchInCompleted = new System.Windows.Forms.TextBox();
            this.tbxSearchInNotCompleted = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReturnProccessDone = new System.Windows.Forms.Button();
            this.tbxDueDate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxLoanDate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxBookName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblPenaltyFee = new System.Windows.Forms.Label();
            gbxInformation = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCompletedReturns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwNotCompletedReturns)).BeginInit();
            gbxInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwCompletedReturns
            // 
            this.dgwCompletedReturns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCompletedReturns.Location = new System.Drawing.Point(12, 284);
            this.dgwCompletedReturns.Name = "dgwCompletedReturns";
            this.dgwCompletedReturns.RowHeadersWidth = 51;
            this.dgwCompletedReturns.RowTemplate.Height = 24;
            this.dgwCompletedReturns.Size = new System.Drawing.Size(421, 154);
            this.dgwCompletedReturns.TabIndex = 0;
            // 
            // dgwNotCompletedReturns
            // 
            this.dgwNotCompletedReturns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwNotCompletedReturns.Location = new System.Drawing.Point(439, 284);
            this.dgwNotCompletedReturns.Name = "dgwNotCompletedReturns";
            this.dgwNotCompletedReturns.RowHeadersWidth = 51;
            this.dgwNotCompletedReturns.RowTemplate.Height = 24;
            this.dgwNotCompletedReturns.Size = new System.Drawing.Size(421, 154);
            this.dgwNotCompletedReturns.TabIndex = 1;
            this.dgwNotCompletedReturns.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwNotCompletedReturns_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "İADE EDİLENLER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(219, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ara :";
            // 
            // tbxSearchInCompleted
            // 
            this.tbxSearchInCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSearchInCompleted.Location = new System.Drawing.Point(262, 251);
            this.tbxSearchInCompleted.Name = "tbxSearchInCompleted";
            this.tbxSearchInCompleted.Size = new System.Drawing.Size(171, 27);
            this.tbxSearchInCompleted.TabIndex = 4;
            this.tbxSearchInCompleted.TextChanged += new System.EventHandler(this.tbxSearchInCompleted_TextChanged);
            // 
            // tbxSearchInNotCompleted
            // 
            this.tbxSearchInNotCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSearchInNotCompleted.Location = new System.Drawing.Point(693, 251);
            this.tbxSearchInNotCompleted.Name = "tbxSearchInNotCompleted";
            this.tbxSearchInNotCompleted.Size = new System.Drawing.Size(171, 27);
            this.tbxSearchInNotCompleted.TabIndex = 7;
            this.tbxSearchInNotCompleted.TextChanged += new System.EventHandler(this.tbxSearchInNotCompleted_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(650, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ara :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(439, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "İADE EDİLMEYENLER";
            // 
            // gbxInformation
            // 
            gbxInformation.Controls.Add(this.btnReturnProccessDone);
            gbxInformation.Controls.Add(this.tbxDueDate);
            gbxInformation.Controls.Add(this.label9);
            gbxInformation.Controls.Add(this.tbxLoanDate);
            gbxInformation.Controls.Add(this.label8);
            gbxInformation.Controls.Add(this.tbxBookName);
            gbxInformation.Controls.Add(this.label7);
            gbxInformation.Controls.Add(this.tbxLastName);
            gbxInformation.Controls.Add(this.label6);
            gbxInformation.Controls.Add(this.tbxFirstName);
            gbxInformation.Controls.Add(this.label5);
            gbxInformation.Location = new System.Drawing.Point(12, 12);
            gbxInformation.Name = "gbxInformation";
            gbxInformation.Size = new System.Drawing.Size(619, 233);
            gbxInformation.TabIndex = 8;
            gbxInformation.TabStop = false;
            gbxInformation.Text = "Bilgi Kutusu";
            // 
            // btnReturnProccessDone
            // 
            this.btnReturnProccessDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnReturnProccessDone.Location = new System.Drawing.Point(412, 114);
            this.btnReturnProccessDone.Name = "btnReturnProccessDone";
            this.btnReturnProccessDone.Size = new System.Drawing.Size(192, 27);
            this.btnReturnProccessDone.TabIndex = 15;
            this.btnReturnProccessDone.Text = "İade Edildi";
            this.btnReturnProccessDone.UseVisualStyleBackColor = false;
            this.btnReturnProccessDone.Click += new System.EventHandler(this.btnReturnProccessDone_Click);
            // 
            // tbxDueDate
            // 
            this.tbxDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxDueDate.Location = new System.Drawing.Point(412, 72);
            this.tbxDueDate.Name = "tbxDueDate";
            this.tbxDueDate.Size = new System.Drawing.Size(192, 27);
            this.tbxDueDate.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(280, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Verilecek Tarih :";
            // 
            // tbxLoanDate
            // 
            this.tbxLoanDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxLoanDate.Location = new System.Drawing.Point(412, 31);
            this.tbxLoanDate.Name = "tbxLoanDate";
            this.tbxLoanDate.Size = new System.Drawing.Size(192, 27);
            this.tbxLoanDate.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(289, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Verildiği Tarih :";
            // 
            // tbxBookName
            // 
            this.tbxBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxBookName.Location = new System.Drawing.Point(77, 114);
            this.tbxBookName.Name = "tbxBookName";
            this.tbxBookName.Size = new System.Drawing.Size(192, 27);
            this.tbxBookName.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(16, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Kitap :";
            // 
            // tbxLastName
            // 
            this.tbxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxLastName.Location = new System.Drawing.Point(77, 72);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(192, 27);
            this.tbxLastName.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(8, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Soyad :";
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxFirstName.Location = new System.Drawing.Point(77, 31);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(192, 27);
            this.tbxFirstName.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(34, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ad :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(638, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Güncel Toplam Tutar :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(651, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "Güncel Ceza Tutarı :";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(783, 49);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(31, 16);
            this.lblTotalCost.TabIndex = 11;
            this.lblTotalCost.Text = "00 ₺";
            // 
            // lblPenaltyFee
            // 
            this.lblPenaltyFee.AutoSize = true;
            this.lblPenaltyFee.Location = new System.Drawing.Point(783, 90);
            this.lblPenaltyFee.Name = "lblPenaltyFee";
            this.lblPenaltyFee.Size = new System.Drawing.Size(31, 16);
            this.lblPenaltyFee.TabIndex = 12;
            this.lblPenaltyFee.Text = "00 ₺";
            // 
            // frmStateOfDue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 450);
            this.Controls.Add(this.lblPenaltyFee);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(gbxInformation);
            this.Controls.Add(this.tbxSearchInNotCompleted);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxSearchInCompleted);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwNotCompletedReturns);
            this.Controls.Add(this.dgwCompletedReturns);
            this.Name = "frmStateOfDue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İade Durumları";
            this.Load += new System.EventHandler(this.frmStateOfDue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCompletedReturns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwNotCompletedReturns)).EndInit();
            gbxInformation.ResumeLayout(false);
            gbxInformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwCompletedReturns;
        private System.Windows.Forms.DataGridView dgwNotCompletedReturns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxSearchInCompleted;
        private System.Windows.Forms.TextBox tbxSearchInNotCompleted;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReturnProccessDone;
        private System.Windows.Forms.TextBox tbxDueDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxLoanDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxBookName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblPenaltyFee;
    }
}