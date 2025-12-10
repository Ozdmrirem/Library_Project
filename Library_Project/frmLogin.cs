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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = SqlCon.Connect())
            {
                connection.Open();
                string queryforLogin = "Select * from AppUsers where UserName = @username and Password = @password";

                using (SqlCommand cmd = new SqlCommand(queryforLogin, connection))
                {
                    cmd.Parameters.AddWithValue("@username", tbxUsername.Text);
                    cmd.Parameters.AddWithValue("@password", tbxPassword.Text);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            MessageBox.Show("Giriş Başarılı");
                        }

                        else
                        {
                            MessageBox.Show("Giriş Başarısız");
                        }
                    }
                }
            }
        }
    }
}

