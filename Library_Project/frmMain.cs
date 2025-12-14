using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Project
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblUserId.Text=Session.ActiveUserId.ToString();
            lblRoleName.Text=Session.ActiveRoleName.ToString();
            lblUsername.Text=Session.ActiveUserName.ToString();

        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            frmBooks books = new frmBooks();
            books.Show();
            this.Hide();
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            frmMembers members = new frmMembers();
            members.Show();
            this.Hide();
        }
    }
}
