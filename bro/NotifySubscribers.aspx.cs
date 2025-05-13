using System;
using System.Net.Mail;
using System.Net;
using bro.Models;
using Notifications;
using System.Linq;


namespace bro
{
    public partial class NotifySubscribers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            string message = txtMessage.Text;

            try
            {
                using (var db = new GamePulseDBContext())
                {
                    var emailSubscribers = db.Subscriptions
                                             .Where(s => s.NotifyByEmail)
                                             .ToList();

                    foreach (var subscriber in emailSubscribers)
                    {
                        MailMessage mail = new MailMessage();
                        mail.To.Add(subscriber.Email);
                        mail.From = new MailAddress("siyabongmelissa@gmail.com");
                        mail.Subject = "Game Update from SZS Game Pulse";
                        mail.Body = message;
                        mail.IsBodyHtml = true;

                        SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                        smtp.Credentials = new NetworkCredential("siyabongmelissa@gmail.com", "iwswiecdznirbubq");
                        smtp.EnableSsl = true;

                        smtp.Send(mail);
                    }

                    lblStatus.Text = "Emails successfully sent to all email subscribers.";
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Error: " + ex.Message;
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
