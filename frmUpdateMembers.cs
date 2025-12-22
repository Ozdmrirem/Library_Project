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
        public frmUpdateMembers(int selectedUserId)
        {
            InitializeComponent();
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
                string query = "SELECT \r\nau.UserId,au.FirstName,au.LastName, \r\nSTRING_AGG(ar.RoleName, ' , ') as Roles ,\r\nau.IdentityNumber,au.BirthDate,au.CreatedDate,au.Gender,au.UserName,au.Password\r\nFROM AppUsers au \r\nINNER JOIN UserRoles ur \r\nON ur.UserId = au.UserId \r\nINNER JOIN AppRoles ar \r\nON ar.RoleId = ur.RoleId \r\nWHERE au.UserId = @userId\r\nGROUP BY \r\nau.UserId,au.FirstName,au.LastName,au.IdentityNumber,au.BirthDate,au.CreatedDate,au.Gender,au.UserName,au.Password";
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

                                tbxUserName.Text = dt["UserName"].ToString();
                                tbxPassword.Text = dt["Password"].ToString();
                            }
                        }
                    }
                }
            }
        }
    }
}