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
    public partial class frmPastTransactions : Form
    {
        int _selectedId;
        public frmPastTransactions(int selectedId)
        {
            InitializeComponent();
            _selectedId = selectedId;
        }

        private void frmPastTransactions_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = SqlCon.Connect())
            {
                string queryForDatas = "SELECT au.FirstName,au.LastName,au.IdentityNumber,b.BookName,b.PublisherName,\r\nbl.LoanDate,bl.DueDate,bl.ReturnDate,bl.PenaltyFee,bl.TotalCost,bl.Status FROM BookLoans bl \r\nINNER JOIN AppUsers au\r\nON au.UserId = bl.UserId\r\nINNER JOIN Books b\r\nON b.BookId=bl.BookId\r\nWHERE bl.UserId = @userId";

                using (SqlCommand cmd = new SqlCommand(queryForDatas, conn))
                {
                    cmd.Parameters.AddWithValue("@userId",_selectedId);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);

                    dgwPastTransactions.DataSource = ds.Tables[0];

                }
            }
        }
    }
}
