using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;

namespace Smart_Time_Attendance
{
    public class Email
    {
       
        public void Send_email(string email_sender, string password_sender,string email_to,string Subject_email,string Message_email) { 
        
        SmtpClient client = new SmtpClient()
        {
            Host = "smtp.gmail.com",
            Port = 587,
            EnableSsl = true,
            DeliveryMethod = SmtpDeliveryMethod.Network,
            UseDefaultCredentials = false,
            Credentials = new NetworkCredential()
            {
                UserName = email_sender,
                Password = password_sender
            }

        };

        MailAddress frommail = new MailAddress(email_sender);
        MailAddress tomail = new MailAddress(email_to);
        MailMessage message = new MailMessage(frommail.ToString(), tomail.ToString(),Subject_email,Message_email);

            try
            {
                client.Send(message);
                MessageBox.Show("Send mail complete");
            }
            catch (Exception)
            {

                MessageBox.Show("Process send mail error");
            }







        }





    }
}
