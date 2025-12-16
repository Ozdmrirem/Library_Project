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
    public partial class frmUpdateBooks : Form
    {
        private int _selectedBookId,_selectedAuthorId;
        public frmUpdateBooks(int selectedBookId,int selectedAuthorId)
        {
            InitializeComponent();
            _selectedBookId = selectedBookId;
            _selectedAuthorId = selectedAuthorId;
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

        void BringOtherDatas()
        {
            using (SqlConnection conn = SqlCon.Connect())
            {
                conn.Open();

                string queryForDatas = "SELECT * FROM Books WHERE BookId = @bookId";
                using (SqlCommand cmd = new SqlCommand(queryForDatas, conn))
                {
                    cmd.Parameters.AddWithValue("@bookId",_selectedBookId);

                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        if (dataReader.Read())
                        {
                            tbxBookName.Text = dataReader["BookName"].ToString();
                            tbxPublisher.Text = dataReader["PublisherName"].ToString();
                            dtpReleasedDate.Value = Convert.ToDateTime(dataReader["ReleasedDate"]);
                            numPageCount.Value = Convert.ToInt16(dataReader["PageCount"]);
                            numStock.Value = Convert.ToInt16(dataReader["QuantityInStocks"]);

                            bool isDeleted = Convert.ToBoolean(dataReader["Status"]);

                            if(isDeleted == true)
                            {
                                rbNotDeleted.Checked = true;
                            }
                            else
                            {
                                rbDeleted.Checked = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Bir hata oluştu.");
                        }
                    }
                }
            }
        }

        void UpdateDatas()
        {
            using (SqlConnection conn = SqlCon.Connect())
            {
                bool isUpdated = false;
                    
                conn.Open();

                string queryForAuthor = "UPDATE BookAuthors SET AuthorId=@authorId WHERE BookId=@bookId";

                using (SqlCommand cmd = new SqlCommand(queryForAuthor, conn))
                {
                    cmd.Parameters.AddWithValue("@authorId", cbxAuthorName.SelectedValue);
                    cmd.Parameters.AddWithValue("@bookId", _selectedBookId);

                    cmd.ExecuteNonQuery();

                    isUpdated = true;
                }

                string queryForUpdate = "UPDATE Books SET BookName=@bookName, PublisherName=@publisherName, ReleasedDate=@releasedDate, PageCount=@pageCount, QuantityInStocks=@stock, Status=@status , ModifiedDate = @modifiedDate WHERE BookId=@bookId";

                using (SqlCommand cmd = new SqlCommand(queryForUpdate,conn))
                {
                    cmd.Parameters.AddWithValue("@bookName", tbxBookName.Text);
                    cmd.Parameters.AddWithValue("@publisherName", tbxPublisher.Text);
                    cmd.Parameters.AddWithValue("@releasedDate", Convert.ToDateTime(dtpReleasedDate.Value));
                    cmd.Parameters.AddWithValue("@pageCount", Convert.ToInt16(numPageCount.Value));
                    cmd.Parameters.AddWithValue("@stock", Convert.ToInt16(numStock.Value));
                    cmd.Parameters.AddWithValue("@modifiedDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@bookId", _selectedBookId);

                    if (rbDeleted.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("@status", false);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@status", true);
                    }

                    if (isUpdated == true)
                    {
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Veriler başarıyla güncellendi.");
                    }
                    else
                    {
                        MessageBox.Show("Hata.");
                    }
                }
            }
        }

           

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateDatas();
        }

        private void frmUpdateBooks_Load(object sender, EventArgs e)
        {
            ListAuthors();
            cbxAuthorName.SelectedValue= _selectedAuthorId;
            BringOtherDatas();
        }
    }
}
