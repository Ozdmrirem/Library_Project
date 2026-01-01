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
    public partial class frmUpdateMembers : Form
    {
        int _selectedUserId;
        public frmUpdateMembers()
        {
            InitializeComponent();
        }
        public frmUpdateMembers(int selectedUserId) : this()
        {
            _selectedUserId = selectedUserId;
        }

        private void frmUpdateMembers_Load(object sender, EventArgs e)
        {
            tbxUserName.Enabled = false;
            tbxPassword.Enabled = false;
            LoadDatas();
        }


        private void LoadDatas()
        {
            using (SqlConnection conn = SqlCon.Connect())
            {
                conn.Open();
                string query = "SELECT \r\nau.UserId, au.FirstName, au.LastName,\r\nSTRING_AGG(ar.RoleName, ' , ') AS Roles,\r\nau.IdentityNumber, au.BirthDate, au.CreatedDate, au.Gender, au.UserName, au.Password\r\nFROM AppUsers au \r\nINNER JOIN UserRoles ur ON ur.UserId = au.UserId \r\nINNER JOIN AppRoles ar ON ar.RoleId = ur.RoleId\r\nWHERE au.UserId = @userId\r\nGROUP BY  \r\nau.UserId, au.FirstName, au.LastName, au.IdentityNumber, au.BirthDate, au.CreatedDate, au.Gender, au.UserName, au.Password";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", _selectedUserId);

                    using (SqlDataReader dt = cmd.ExecuteReader())
                    {
                        if (dt.Read())
                        {
                            tbxFirstName.Text = dt["FirstName"].ToString();
                            tbxLastName.Text = dt["LastName"].ToString();
                            tbxIdentityNumber.Text = dt["IdentityNumber"].ToString();
                            dtpBirthDate.Value = Convert.ToDateTime(dt["BirthDate"]);

                            bool gender = Convert.ToBoolean(dt["Gender"]);
                            if (gender == true)
                            {
                                rbMan.Checked = true;
                            }
                            else
                            {
                                rbWoman.Checked = true;
                            }

                            string roles = dt["Roles"].ToString();
                            if(roles.Contains("Superadmin"))
                            {
                                chkSuperAdmin.Checked = true;
                            }
                            if (roles.Contains("Admin"))
                            {
                                chkAdmin.Checked = true;
                            }
                            if (roles.Contains("Member"))
                            {
                                chkMember.Checked = true;
                            }

                            if(chkAdmin.Checked || chkSuperAdmin.Checked)
                            {
                                tbxUserName.Enabled = true;
                                tbxPassword.Enabled = true;

                                tbxUserName.Text = dt["Username"].ToString();
                                tbxPassword.Text = dt["Password"].ToString();
                            }
                        }
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ModifyUserRoles();
            ModifyUserDatas();
        }

        private void ModifyUserDatas()
        {
            try
            {
                using (SqlConnection conn = SqlCon.Connect())
                {
                    conn.Open();
                    string query = "UPDATE AppUsers SET FirstName = @firstName, LastName = @lastName, IdentityNumber = @identityNumber, BirthDate = @birth  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata 3 : " + ex.Message);
            }
        }

        private void ModifyUserRoles()
        {
            try
            {
                using (SqlConnection conn = SqlCon.Connect())
                {
                    conn.Open();

                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            List<int> toBeInsertedRoles = new List<int>();

                            if (chkSuperAdmin.Checked)
                            {
                                toBeInsertedRoles.Add(1);
                            }
                            if (chkAdmin.Checked)
                            {
                                toBeInsertedRoles.Add(2);
                            }
                            if (chkMember.Checked)
                            {
                                toBeInsertedRoles.Add(3);
                            }

                            string rolesQuery = "SELECT * FROM UserRoles WHERE UserId = @userId";

                            using (SqlCommand cmd = new SqlCommand(rolesQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@userId", _selectedUserId);

                                List<int> currentUserRoles = new List<int>();
                                using (SqlDataReader dr = cmd.ExecuteReader())
                                {
                                    while (dr.Read())
                                    {
                                        currentUserRoles.Add(Convert.ToInt32(dr["RoleId"]));

                                    }
                                }
                                foreach (var roleId in toBeInsertedRoles.Except(currentUserRoles))
                                    {
                                        string queryForInsert = "INSERT INTO UserRoles (RoleId,UserId) VALUES (@roleId,@userId)";

                                        using (SqlCommand cmdForInsert = new SqlCommand(queryForInsert, conn, transaction))
                                        {
                                            cmdForInsert.Parameters.AddWithValue("@roleId", roleId);
                                            cmdForInsert.Parameters.AddWithValue("@userId", _selectedUserId);

                                            cmdForInsert.ExecuteNonQuery();
                                        }
                                    }

                                    //Silme islemi
                                    foreach (var roleId in currentUserRoles.Except(toBeInsertedRoles))
                                    {
                                        string queryForDelete = "DELETE FROM UserRoles WHERE UserId = @userId  AND RoleId = @roleId ";

                                        using (SqlCommand cmdForDelete = new SqlCommand(queryForDelete, conn, transaction))
                                        {
                                            cmdForDelete.Parameters.AddWithValue("@userId", _selectedUserId);
                                            cmdForDelete.Parameters.AddWithValue("@roleId", roleId);

                                            cmdForDelete.ExecuteNonQuery();
                                        }
                                    }

                                    if (toBeInsertedRoles.Contains(1))
                                    {
                                        if (!toBeInsertedRoles.Contains(2))
                                        {
                                            string insertAdminRoleQuery = "INSERT INTO UserRoles (UserId,RoleId) VALUES (@userId,@roleId)";

                                            using (SqlCommand cmdForAdminInsert = new SqlCommand(insertAdminRoleQuery, conn, transaction))
                                            {
                                                cmdForAdminInsert.Parameters.AddWithValue("@userId", _selectedUserId);
                                                cmdForAdminInsert.Parameters.AddWithValue("@roleId", 2);

                                                cmdForAdminInsert.ExecuteNonQuery();
                                            }
                                        }

                                        if (!toBeInsertedRoles.Contains(3))
                                        {
                                            string insertMemberRoleQuery = "INSERT INTO UserRoles (UserId,RoleId) VALUES (@userId,@roleId)";

                                            using (SqlCommand cmdForMemberInsert = new SqlCommand(insertMemberRoleQuery, conn, transaction))
                                            {
                                                cmdForMemberInsert.Parameters.AddWithValue("@userId", _selectedUserId);
                                                cmdForMemberInsert.Parameters.AddWithValue("@roleId", 3);

                                                cmdForMemberInsert.ExecuteNonQuery();
                                            }
                                        }
                                    }

                                    else if (toBeInsertedRoles.Contains(2) && !toBeInsertedRoles.Contains(3))
                                    {
                                        string insertMember2RoleQuery = "INSERT INTO UserRoles (UserId,RoleId) VALUES (@userId,@roleId)";

                                        using (SqlCommand cmdForMember2Insert = new SqlCommand(insertMember2RoleQuery, conn, transaction))
                                        {
                                            cmdForMember2Insert.Parameters.AddWithValue("@userId", _selectedUserId);
                                            cmdForMember2Insert.Parameters.AddWithValue("@roleId", 3);

                                            cmdForMember2Insert.ExecuteNonQuery();
                                        }
                                    }

                                    transaction.Commit();
                                    MessageBox.Show("Kullanıcı eklendi.");
                                
                            }
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Hata2" + ex);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata" + ex);
            }
        }
    }
}