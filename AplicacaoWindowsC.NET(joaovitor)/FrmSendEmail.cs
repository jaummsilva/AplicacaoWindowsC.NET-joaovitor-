using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AplicacaoWindowsC.NET_joaovitor_
{
    public partial class FrmSendEmail : Form
    {
        public FrmSendEmail()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {

                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("jaumm.silva.04@gmail.com");
                msg.To.Add(textBoxTo.Text);
                msg.Subject = textBoxSubject.Text;
                msg.Body = textBoxTextEmail.Text;

                SmtpClient smt = new SmtpClient();
                smt.Host = "smtp.gmail.com";
                NetworkCredential ntcd = new NetworkCredential();
                ntcd.UserName = "jaumm.silva.04@gmail.com";
                ntcd.Password = "Jaumm#99";
                smt.Credentials = ntcd;
                smt.EnableSsl = true;
                smt.Port = 587;
                smt.Send(msg);

                MessageBox.Show("Your Mail is sended");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
