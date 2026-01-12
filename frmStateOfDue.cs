using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Project
{
    public partial class frmStateOfDue : Form
    {
        public frmStateOfDue()
        {
            InitializeComponent();
        }

        private void frmStateOfDue_Load(object sender, EventArgs e)
        {
            BringAndSearchCompleted();
            BringAndSearchNotCompleted();
        }

        void BringAndSearchCompleted()
        {
            using (SqlConnection conn = SqlCon.Connect())
            {
                conn.Open();

                string queryForCompleted = "SELECT bl.LoanId, au.FirstName, au.LastName, au.IdentityNumber, b.BookName,\r\nb.PublisherName, bl.LoanDate, bl.DueDate, bl.ReturnDate, bl.PenaltyFee,bl.TotalCost\r\nFROM BookLoans bl\r\nINNER JOIN AppUsers au\r\nON au.UserId = bl.UserId\r\nINNER JOIN Books b\r\nON b.BookId=bl.BookId\r\nWHERE bl.Status = 0\r\nAND (au.FirstName + au.LastName LIKE @keyWord OR au.IdentityNumber LIKE @keyWord OR b.BookName LIKE @keyWord)";

                using (SqlCommand cmd = new SqlCommand(queryForCompleted, conn))
                {
                    cmd.Parameters.AddWithValue("@keyWord",'%' + tbxSearchInCompleted.Text + '%');

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);

                    dgwCompletedReturns.DataSource = dataSet.Tables[0];
                }
            }
        }

        void BringAndSearchNotCompleted()
        {
            using (SqlConnection conn = SqlCon.Connect())
            {
                conn.Open();

                string queryForNotCompleted = "SELECT bl.LoanId, au.FirstName, au.LastName, au.IdentityNumber, b.BookName,b.PublisherName, bl.LoanDate, bl.DueDate FROM BookLoans bl\r\nINNER JOIN AppUsers au\r\nON au.UserId = bl.UserId\r\nINNER JOIN Books b\r\nON b.BookId=bl.BookId\r\nWHERE bl.Status = 1\r\nAND (au.FirstName + au.LastName LIKE @keyWord OR au.IdentityNumber LIKE @keyWord OR b.BookName LIKE @keyWord)";
                

                using (SqlCommand cmd = new SqlCommand(queryForNotCompleted, conn))
                {
                    cmd.Parameters.AddWithValue("@keyWord", '%' + tbxSearchInNotCompleted.Text + '%');

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);

                    dgwNotCompletedReturns.DataSource = dataSet.Tables[0];
                }
            }
        }

        private void tbxSearchInCompleted_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbxSearchInCompleted.Text))
            {
                BringAndSearchCompleted();
            }
        }

        private void tbxSearchInNotCompleted_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxSearchInNotCompleted.Text))
            {
                BringAndSearchNotCompleted();
            }
        }

        int _selectedLoanId;

        private void dgwNotCompletedReturns_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _selectedLoanId = Convert.ToInt32(dgwNotCompletedReturns.CurrentRow.Cells[0].Value);
            tbxFirstName.Text= dgwNotCompletedReturns.CurrentRow.Cells[1].Value.ToString();
            tbxLastName.Text= dgwNotCompletedReturns.CurrentRow.Cells[2].Value.ToString();
            tbxBookName.Text= dgwNotCompletedReturns.CurrentRow.Cells[4].Value.ToString();
            tbxDueDate.Text= dgwNotCompletedReturns.CurrentRow.Cells[7].Value.ToString();
            tbxLoanDate.Text= dgwNotCompletedReturns.CurrentRow.Cells[6].Value.ToString();

        }

        private void btnReturnProccessDone_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("İade işlemimini tamamlamak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {

                using (SqlConnection conn = SqlCon.Connect())
                {
                    conn.Open();

                    string doneQuery = "UPDATE BookLoans SET Status = 0 ,ReturnDate = @returnDate, PenaltyFee = @penaltyFee, TotalCost = @totalCost WHERE LoanId = @loanId";

                    using (SqlCommand cmd = new SqlCommand(doneQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@returnDate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@penaltyFee", 35);
                        cmd.Parameters.AddWithValue("@totalCost", 50);
                        cmd.Parameters.AddWithValue("@loanId", _selectedLoanId);

                        cmd.ExecuteNonQuery();
                        BringAndSearchCompleted();
                        BringAndSearchNotCompleted();
                        MessageBox.Show("Kullanıcının iade işlemi tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
        }
    }
}
