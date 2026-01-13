using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Project
{
    public partial class frmSendMail : Form
    {
        public frmSendMail()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string fromMail = "ozdmrirem48@gmail.com";
            string password = "mkcm vlrk dyst dlyg";

            try
            {
                MailMessage mailMessage = new MailMessage();
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");

                mailMessage.From = new MailAddress(fromMail);
                mailMessage.To.Add(tbxToMail.Text);
                mailMessage.Subject = tbxSubject.Text;
                mailMessage.Body = tbxMailContent.Text;

                smtpClient.Port = 587;
                smtpClient.Credentials = new NetworkCredential(fromMail,password);
                smtpClient.EnableSsl = true;
                smtpClient.Send(mailMessage);

                MessageBox.Show($"{tbxToMail.Text} mail adresine gönderildi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
