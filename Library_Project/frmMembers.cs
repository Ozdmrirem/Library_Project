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
                SqlTransaction transaction = conn.BeginTransaction();

                string queryForUser = "INSERT INTO AppUsers (FirstName,LastName,IdentityNumber,Username,Password,BirthDate,Gender) VALUES (@firstName, @lastName,@identityNumber,@username,@password,@birthDate,@gender); SELECT SCOPE_IDENTITY();";

                using (SqlCommand cmdForUser = new SqlCommand(queryForUser,conn,transaction))
                {
                    cmdForUser.Parameters.AddWithValue("@firstName", tbxFirstName.Text);
                    cmdForUser.Parameters.AddWithValue("@lastName", tbxLastName.Text);
                    cmdForUser.Parameters.AddWithValue("@identityNumber", tbxIdentityNumber.Text);
                    cmdForUser.Parameters.AddWithValue("@username",null);
                    cmdForUser.Parameters.AddWithValue("@password",null);
                    cmdForUser.Parameters.AddWithValue("@birthDate", dtpBirthDate.Value);

                    bool gender;
                    gender =rbMan.Checked ? true : false;

                    cmdForUser.Parameters.AddWithValue("@gender", gender);

                    int insertedUserId = Convert.ToInt32(cmdForUser.ExecuteScalar());

                    if(chkMember.Checked)
                    {

                    }
                    if(chkAdmin.Checked)
                    {

                    }
                    if (chkSuperAdmin.Checked)
                    {
                        
                    }
                }
            }
        }
    }
}
