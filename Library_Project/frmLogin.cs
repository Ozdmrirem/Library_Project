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
            string username = tbxUsername.Text;
            string password = tbxPassword.Text;

            if (username.Trim().Length == 0 || password.Trim().Length == 0 || username.Contains(" ") || password.Contains(" ") || username.Length < 3 || username.Length > 49 || password.Length < 3 || password.Length > 49)
            {
                MessageBox.Show("Hatalı Giriş Şekli. Lütfen en az 3 karakter giriniz.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                using (SqlConnection connection = SqlCon.Connect())
                {
                    connection.Open();
                    string queryforLogin = "Select TOP(1) au.UserId as UserId,ur.RoleId as RoleId, ar.RoleName as RoleName , au.FirstName + ' ' + au.LastName as FullName from AppUsers au\r\nINNER JOIN UserRoles ur\r\nON au.UserId=ur.UserId\r\nINNER JOIN AppRoles ar\r\nON ar.RoleId=ur.RoleId\r\nwhere UserName = @userName and Password = @password";

                    using (SqlCommand cmd = new SqlCommand(queryforLogin, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", tbxUsername.Text);
                        cmd.Parameters.AddWithValue("@password", tbxPassword.Text);

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                int userId = Convert.ToInt32(dr["UserId"]);
                                int roleId = Convert.ToInt32(dr["RoleId"]);
                                string roleName = dr["RoleName"].ToString();
                                string fullName = dr["FullName"].ToString();

                                Session.ActiveRoleId = roleId;
                                Session.ActiveRoleName = roleName;
                                Session.ActiveUserId = userId;
                                Session.ActiveUserName = fullName;


                                MessageBox.Show($"Hoş Geldiniz {fullName}.\n{roleId} - {roleName}", "Başarılı Giriş",MessageBoxButtons.OK,MessageBoxIcon.Information);

                                frmMain main = new frmMain();
                                main.Show();
                                this.Hide();
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
}

