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
                string queryForDatas = "Select Books.BookId,Books.BookName as Kitap ,\r\nAuthors.FirstName + ' ' + Authors.LastName as Yazar,\r\nBooks.PublisherName as Yayınevi,\r\nBooks.PageCount as [Sayfa Sayısı]\r\nfrom Books\r\ninner join BookAuthors\r\non Books.BookId = BookAuthors.BookId\r\ninner join Authors\r\non Authors.AuthorId=BookAuthors.AuthorId\r\nwhere (Books.BookName like @Words OR Books.PublisherName like @Words OR Authors.FirstName + ' ' + Authors.LastName like @Words)";

                using (SqlCommand cmd = new SqlCommand(queryForDatas,conn))
                {
                    cmd.Parameters.AddWithValue("@Words", '%' + tbxSearchBook.Text + '%');

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);

                    dgwBooks.DataSource = dataSet.Tables[0];
                }
            }
        }

        private void frmBooks_Load(object sender, EventArgs e)
        {
            BringAndSearchDatas();

            tbxAuthorsName.Enabled = false;
            tbxBooksName.Enabled = false;
            tbxPublishersName.Enabled = false;
        }

        private void tbxSearchBook_TextChanged(object sender, EventArgs e)
        {
            if(tbxSearchBook.Text != string.Empty)
            {
                BringAndSearchDatas();
            }
        }

        int _selectedBookId;
        private void dgwBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _selectedBookId = Convert.ToInt32(dgwBooks.CurrentRow.Cells[0].Value);
            tbxBooksName.Text = dgwBooks.CurrentRow.Cells[1].Value.ToString();
            tbxAuthorsName.Text = dgwBooks.CurrentRow.Cells[2].Value.ToString();
            tbxPublishersName.Text = dgwBooks.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bu veriyi silmek istediğinizden emin misiniz ?","Uyarı",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);

            if(res == DialogResult.Yes)
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
    }
}
