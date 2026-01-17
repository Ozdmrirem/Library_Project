using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library_Project
{
    public partial class frmBookLoans : Form
    {
        public frmBookLoans()
        {
            InitializeComponent();
        }

        private void frmBookLoans_Load(object sender, EventArgs e)
        {
            BringAndSearchBooks();
            ChangeStatusOfBookControllers();
            ChangeStatusOfMemberControllers();
            BringAndSearchMembers();
            InformationBox();
        }
        private void BringAndSearchMembers()
        {
            using (SqlConnection conn = SqlCon.Connect())
            {
                conn.Open();

                string query = " SELECT au.UserId,au.FirstName,au.LastName,STRING_AGG(ar.RoleName, ',') AS Roles,au.IdentityNumber,au.BirthDate,au.CreatedDate FROM AppUsers au INNER JOIN UserRoles ur ON ur.UserId = au.UserId INNER JOIN AppRoles ar ON ar.RoleId = ur.RoleId WHERE au.Status = 1 GROUP BY  au.UserId,au.FirstName,au.LastName,au.IdentityNumber,au.BirthDate,au.CreatedDate HAVING (au.FirstName + ' ' + au.LastName LIKE @memberName) OR (au.IdentityNumber LIKE @identityNumber)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@memberName", '%' + tbxSearchMember.Text + '%');
                    cmd.Parameters.AddWithValue("@identityNumber", '%' + tbxSearchMember.Text + '%');


                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);

                    dgwMembers.DataSource = dataSet.Tables[0];

                }
            }
        }

        void InformationBox()
        {
            timer1.Interval = 1000;
            timer1.Start();

            using (SqlConnection conn = SqlCon.Connect())
            {
                conn.Open();

                string queryForCurrentLoans = "SELECT COUNT(*) AS Total FROM BookLoans WHERE Status = 1";

                string queryForTotalLoans = "SELECT COUNT(*) AS Total FROM BookLoans";

                string queryForTotalUsers = "SELECT COUNT(*) AS Total FROM AppUsers WHERE Status = 1";

                using (SqlCommand cmdForCurrentLoans = new SqlCommand(queryForCurrentLoans, conn))
                {
                    using (SqlDataReader drForCurrentLoans = cmdForCurrentLoans.ExecuteReader())
                    {
                        if (drForCurrentLoans.Read())
                        {
                            int totalCurrentLoans = Convert.ToInt32(drForCurrentLoans["Total"]);
                            lblCurrentLoans.Text = "Güncel kiralananlar : " + totalCurrentLoans.ToString();
                        }                          
                    }
                }

                using (SqlCommand cmdForTotalLoans = new SqlCommand(queryForTotalLoans, conn))
                {
                    using (SqlDataReader drForTotalLoans = cmdForTotalLoans.ExecuteReader())
                    {
                        if (drForTotalLoans.Read())
                        {
                            int totalLoans = Convert.ToInt32(drForTotalLoans["Total"]);
                            lblTotalLoans.Text = "Toplam kiralananlar " + totalLoans.ToString();
                        }                   
                    }
                }

                using (SqlCommand cmdForTotalUsers = new SqlCommand(queryForTotalUsers, conn))
                {
                    using (SqlDataReader drForTotalUsers = cmdForTotalUsers.ExecuteReader())
                    {
                        if (drForTotalUsers.Read())
                        {
                            int totalUsers = Convert.ToInt32(drForTotalUsers["Total"]);
                            lblTotalUsers.Text = "Toplam üye : " + totalUsers.ToString();
                        } 
                    }
                }
            }
        }

        void BringAndSearchBooks()
        {
            using (SqlConnection conn = SqlCon.Connect())
            {
                conn.Open();
                string queryForDatas = "SELECT Books.BookId,Books.BookName AS Kitap , Authors.AuthorId, Authors.FirstName + ' ' + Authors.LastName AS Yazar,Books.PublisherName AS Yayınevi,Books.PageCount AS [Sayfa Sayısı], Books.QuantityInStocks FROM Books INNER JOIN BookAuthors ON Books.BookId = BookAuthors.BookId INNER JOIN Authors ON Authors.AuthorId=BookAuthors.AuthorId WHERE (Books.BookName LIKE @Words OR Books.PublisherName LIKE @Words OR Authors.FirstName + ' ' + Authors.LastName LIKE @Words AND Books.Status = 1)";

                using (SqlCommand cmd = new SqlCommand(queryForDatas, conn))
                {
                    cmd.Parameters.AddWithValue("@Words", '%' + tbxSearchBook.Text + '%');

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);

                    dgwBooks.DataSource = dataSet.Tables[0];
                }
            }
        }

        void ChangeStatusOfBookControllers()
        {
            foreach (Control item in gbxBooks.Controls)
            {
                if (item is TextBox)
                {
                    item.Enabled = false;
                }
            }
        }

        void ChangeStatusOfMemberControllers()
        {
            foreach (Control item in gbxMembers.Controls)
            {
                if (item is TextBox)
                {
                    item.Enabled = false;
                }
            }
        }

        private void tbxSearchBook_TextChanged(object sender, EventArgs e)
        {

            if (tbxSearchBook.Text != string.Empty)
            {
                BringAndSearchBooks();
            }
        }


        int _selectedBookId;
        private void dgwBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _selectedBookId = Convert.ToInt32(dgwBooks.CurrentRow.Cells[0].Value);
            tbxBookName.Text = dgwBooks.CurrentRow.Cells[1].Value.ToString();
            tbxAuthorName.Text = dgwBooks.CurrentRow.Cells[3].Value.ToString();
            tbxPublisherName.Text = dgwBooks.CurrentRow.Cells[4].Value.ToString();
            tbxPageCount.Text = dgwBooks.CurrentRow.Cells[5].Value.ToString();
            tbxStock.Text = dgwBooks.CurrentRow.Cells[6].Value.ToString();

        }

        private void tbxSearchMember_TextChanged(object sender, EventArgs e)
        {
            if (tbxSearchMember.Text != string.Empty)
            {
                BringAndSearchMembers();
            }
        }

        int _selectedMemberId;
        private void dgwMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _selectedMemberId = Convert.ToInt32(dgwMembers.CurrentRow.Cells[0].Value);
            tbxFirstName.Text = dgwMembers.CurrentRow.Cells[1].Value.ToString();
            tbxLastName.Text = dgwMembers.CurrentRow.Cells[2].Value.ToString();
            tbxIdentityNumber.Text = dgwMembers.CurrentRow.Cells[4].Value.ToString();
            DateTime birthDate = Convert.ToDateTime(dgwMembers.CurrentRow.Cells[5].Value);
            tbxBirthDate.Text = birthDate.ToString("dd/MM/yyyy");

        }

        private void btnProccessDone_Click(object sender, EventArgs e)
        {
            if (_selectedMemberId < 0 || _selectedBookId < 0 || dtpDueDate.Value < DateTime.Now.AddDays(1))
            {
                MessageBox.Show("Öncelikle kitap, üye ve tarih bilgilerinin doğru olduğundan emin olunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult result = MessageBox.Show($"Kaydı tamamlamak istediğinizden emin misiniz?\nKitap : {tbxBookName.Text.ToString()}\nÜye : {tbxFirstName + " " + tbxLastName.Text.ToString()}", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = SqlCon.Connect())
                    {
                        conn.Open();

                        string insertQuery = "INSERT INTO BookLoans (UserId,BookId,LoanDate,DueDate) VALUES (@userId,@bookId,@loanDate,@dueDate)";

                        using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@userId", _selectedMemberId);
                            cmd.Parameters.AddWithValue("@bookId", _selectedBookId);
                            cmd.Parameters.AddWithValue("@loanDate", DateTime.Now);
                            cmd.Parameters.AddWithValue("@dueDate", dtpDueDate.Value);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Kitap kiralama işlemi başarıyla tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                }
            }
        }

        private void btnStateOfDue_Click(object sender, EventArgs e)
        {
            frmStateOfDue frmStateOfDue = new frmStateOfDue();
            frmStateOfDue.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("ddd  MMM  yyyy");
            lblHour.Text = DateTime.Now.ToString("HH:mm");
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            if(_selectedMemberId < 0)
            {
                MessageBox.Show("Lütfen geçerli bir kullanıcı seçiniz!","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                frmPastTransactions pastTransactions = new frmPastTransactions(_selectedMemberId);
                pastTransactions.ShowDialog();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Hide();
        }
    }
}
