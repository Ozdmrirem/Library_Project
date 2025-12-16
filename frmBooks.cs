using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Library_Project.Tools.FluentValidation.Books;
using Library_Project.Objects.Books;

namespace Library_Project
{
    public partial class frmBooks : Form
    {
        public frmBooks()
        {
            InitializeComponent();
        }

        void BringAndSearchDatas()
        {
            using (SqlConnection conn = SqlCon.Connect())
            {
                conn.Open();
                string queryForDatas = "SELECT Books.BookId,Books.BookName AS Kitap , Authors.AuthorId, Authors.FirstName + ' ' + Authors.LastName AS Yazar,Books.PublisherName AS Yayınevi,Books.PageCount AS [Sayfa Sayısı] FROM Books INNER JOIN BookAuthors ON Books.BookId = BookAuthors.BookId INNER JOIN Authors ON Authors.AuthorId=BookAuthors.AuthorId WHERE (Books.BookName LIKE @Words OR Books.PublisherName LIKE @Words OR Authors.FirstName + ' ' + Authors.LastName LIKE @Words AND Books.Status = 1)";

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

        void ListAuthors()
        {
            using (SqlConnection conn = SqlCon.Connect())
            {
                conn.Open();

                string queryForAuthor = "Select AuthorId, FirstName + ' ' + LastName AS FullName FROM Authors ";

                using (SqlCommand cmd = new SqlCommand(queryForAuthor, conn))
                {
                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(dataReader);

                        cbxAuthorName.DataSource = dataTable;

                        cbxAuthorName.DisplayMember = "FullName";
                        cbxAuthorName.ValueMember = "AuthorId";
                    }
                }
            }
        }

        private void frmBooks_Load(object sender, EventArgs e)
        {
            BringAndSearchDatas();
            ListAuthors();

            tbxUpdateAuthorsName.Enabled = false;
            tbxUpdateBooksName.Enabled = false;
            tbxUpdatePublishersName.Enabled = false;
        }

        private void tbxSearchBook_TextChanged(object sender, EventArgs e)
        {
            if (tbxSearchBook.Text != string.Empty)
            {
                BringAndSearchDatas();
            }
        }

        int _selectedBookId;
        int _selectedAuthorId;
        private void dgwBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _selectedBookId = Convert.ToInt32(dgwBooks.CurrentRow.Cells[0].Value);
            tbxUpdateBooksName.Text = dgwBooks.CurrentRow.Cells[1].Value.ToString();
            _selectedAuthorId = Convert.ToInt32(dgwBooks.CurrentRow.Cells[2].Value);
            tbxUpdateAuthorsName.Text = dgwBooks.CurrentRow.Cells[3].Value.ToString();
            tbxUpdatePublishersName.Text = dgwBooks.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bu veriyi silmek istediğinizden emin misiniz ?", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                using (SqlConnection conn = SqlCon.Connect())
                {
                    conn.Open();

                    string queryForDelete = "UPDATE Books SET Status = 0 WHERE BookId = @bookId";

                    using (SqlCommand cmd = new SqlCommand(queryForDelete, conn))
                    {
                        cmd.Parameters.AddWithValue("bookId", _selectedBookId);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Veri başarıyla silindi.", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdateBooks updateBooks = new frmUpdateBooks(_selectedBookId, _selectedAuthorId);
            updateBooks.ShowDialog();

        }

        private void btnInsertBook_Click(object sender, EventArgs e)
        {
            var validator = new BookInsertValidator();

            var insertBookObject = new InsertBook
            {
                BookName = tbxBookName.Text,
                PublisherName = tbxPublisher.Text
            };

            var result = validator.Validate(insertBookObject);

            if (result.IsValid)
            {
                InsertNewBook();
            }
            else 
            {
                foreach (var error in result.Errors)
                {
                    MessageBox.Show("Hata : " + error.ErrorMessage);
                }
            }
        }
        private void InsertNewBook()
        {
            using (SqlConnection conn= SqlCon.Connect())
            {
                conn.Open();

                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    string queryForNewBook = "INSERT INTO Books (BookName,PublisherName,ReleasedDate,PageCount,QuantityInStocks,CreatedBy) VALUES (@bookName,@publisherName,@releasedDate,@pageCount,@quantityInStocks,@createdBy); SELECT SCOPE_IDENTITY();";

                    using (SqlCommand cmd = new SqlCommand(queryForNewBook,conn,transaction))
                    {
                        cmd.Parameters.AddWithValue("@bookName", tbxBookName.Text);
                        cmd.Parameters.AddWithValue("@publisherName", tbxPublisher.Text);
                        cmd.Parameters.AddWithValue("@releasedDate", dtpReleasedDate.Value);
                        cmd.Parameters.AddWithValue("@pageCount", Convert.ToInt32(numPageCount.Value));
                        cmd.Parameters.AddWithValue("@quantityInStocks", Convert.ToInt32(numStock.Value));
                        cmd.Parameters.AddWithValue("@createdBy", Session.ActiveUserId);

                        int insertedBookId = Convert.ToInt32(cmd.ExecuteScalar());

                        string queryForAuthor = "INSERT INTO BookAuthors (BookId,AuthorId) VALUES (@bookId,@authorId)";

                        using (SqlCommand cmdAuthor = new SqlCommand(queryForAuthor, conn,transaction))
                        {
                            cmdAuthor.Parameters.AddWithValue("@bookId", insertedBookId);
                            cmdAuthor.Parameters.AddWithValue("@authorId", cbxAuthorName.SelectedValue);

                            cmdAuthor.ExecuteNonQuery();

                            MessageBox.Show("Veri ekleme işlemi başarılı.", "Veri Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
