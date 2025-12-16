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
    public partial class frmMembers : Form
    {
        public frmMembers()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = SqlCon.Connect())
            {
                conn.Open();

                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    string queryForUser = "INSERT INTO AppUsers (FirstName,LastName,IdentityNumber,Username,Password,BirthDate,Gender) VALUES (@firstName, @lastName,@identityNumber,@username,@password,@birthDate,@gender); SELECT SCOPE_IDENTITY();";

                    using (SqlCommand cmdForUser = new SqlCommand(queryForUser, conn, transaction))
                    {
                        cmdForUser.Parameters.AddWithValue("@firstName", tbxFirstName.Text);
                        cmdForUser.Parameters.AddWithValue("@lastName", tbxLastName.Text);
                        cmdForUser.Parameters.AddWithValue("@identityNumber", tbxIdentityNumber.Text);

                        string username = tbxUserName.Text;
                        string password = tbxPassword.Text;


                        cmdForUser.Parameters.AddWithValue("@username", tbxUserName.Text);
                        cmdForUser.Parameters.AddWithValue("@password", tbxPassword.Text);
                        cmdForUser.Parameters.AddWithValue("@birthDate", dtpBirthDate.Value);

                        bool gender;
                        gender = rbMan.Checked ? true : false;

                        cmdForUser.Parameters.AddWithValue("@gender", gender);

                        int insertedUserId = Convert.ToInt32(cmdForUser.ExecuteScalar());

                        if (chkMember.Checked)
                        {
                            AssignRoleToUser(conn, transaction, insertedUserId, 3);
                        }
                        if (chkAdmin.Checked)
                        {
                            AssignRoleToUser(conn, transaction, insertedUserId, 2);
                        }
                        if (chkSuperAdmin.Checked)
                        {
                            if (Session.ActiveRoleId != 1)
                            {
                                MessageBox.Show("Yetkiniz yönetici eklemek için yetersiz! Diğer yetkiler eklendi.");
                            }
                            else
                            {
                                AssignRoleToUser(conn, transaction, insertedUserId, 1);
                            }
                        }

                        transaction.Commit(); 

                        MessageBox.Show("Veriler eklendi.");
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Hata" + ex.Message);
                }
            }
        }
        

        private void AssignRoleToUser(SqlConnection conn, SqlTransaction transaction, int insertedUserId, int roleId)
        {
            string queryForRole = "INSERT INTO UserRoles (RoleId, UserId) VALUES (@roleId, @userId);";

            using (SqlCommand cmdForRole = new SqlCommand(queryForRole, conn, transaction))
            {
                cmdForRole.Parameters.AddWithValue("@roleId", roleId);
                cmdForRole.Parameters.AddWithValue("@userId", insertedUserId);

                cmdForRole.ExecuteNonQuery();

            }
        }

        private void frmMembers_Load(object sender, EventArgs e)
        {
            ChangePassive();
            BringAndSearchMemberDatas();
        }

        private void BringAndSearchMemberDatas()
        {
            using (SqlConnection conn = SqlCon.Connect())
            {
                conn.Open();

                string query = "SELECT au.FirstName,au.LastName, STRING_AGG(ar.RoleName, ' , ') as Roles ,au.IdentityNumber,au.BirthDate,au.CreatedDate FROM AppUsers au INNER JOIN UserRoles ur ON ur.UserId = au.UserId INNER JOIN AppRoles ar ON ar.RoleId = ur.RoleId GROUP BY  au.FirstName,au.LastName,au.IdentityNumber,au.BirthDate,au.CreatedDate HAVING (au.FirstName + ' ' + au.LastName LIKE @memberName) OR (au.IdentityNumber LIKE @identityNumber) ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@memberName", '%' + tbxMember.Text + '%');
                    cmd.Parameters.AddWithValue("@identityNumber", '%' + tbxMember.Text + '%');

                   
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                        DataSet dataSet = new DataSet();
                        dataAdapter.Fill(dataSet);

                        dgwMembers.DataSource = dataSet.Tables[0];
                    
                }
            }
        }

        void ChangePassive()
        {
            tbxUserName.Enabled = false;
            tbxPassword.Enabled = false;
        }

        private void chkAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAdmin.Checked)
            {
                tbxUserName.Enabled = true;
                tbxPassword.Enabled = true;
            }
            else
            {
                ChangePassive();
            }
        }

        private void chkSuperAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSuperAdmin.Checked)
            {
                tbxUserName.Enabled = true;
                tbxPassword.Enabled = true;
            }
            else
            {
                ChangePassive();
            }
        }

        private void tbxMember_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxMember.Text))
            {
                BringAndSearchMemberDatas();
            }
        }
    }



    
}
