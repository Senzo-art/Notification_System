using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using bro.Models;
using Notifications;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using Twilio;


namespace bro
{
    public partial class Subscribe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        

        protected void btnSubscribe_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new GamePulseDBContext())
                {
                    var subscription = new Subscriptions
                    {
                        Email = txtEmail.Text,
                        NotifyByEmail = chkEmail.Checked,
                        NotifyBySMS = chkSMS.Checked,
                        NotifyByPush = chkPush.Checked,
                        PhoneNumber = txtPhoneNumber.Text,
                        DateSubscribed = DateTime.Now
                    };
                    db.Subscriptions.Add(subscription);
                    db.SaveChanges();
                }

                string to = txtEmail.Text;
                string subject = "Welcome to SZS Game Pulse!";
                string body = "Thanks for subscribing! 🎮 You'll now receive game updates, price drops, and more.";

                MailMessage mail = new MailMessage();
                mail.To.Add(to);
                mail.From = new MailAddress("siyabongmelissa@gmail.com");
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("siyabongmelissa@gmail.com", "iwswiecdznirbubq");
                smtp.EnableSsl = true;

                smtp.Send(mail);

                Response.Write("<script>alert('Subscription confirmed! Email sent.');</script>");
            }
            catch (Exception ex)
            {
                // Optionally handle errors
                Response.Write("<script>alert('Error sending email: " + ex.Message + "');</script>");
            }
        }

        public void SendSms(string toPhone, string message)
        {
            const string accountSid = "your_twilio_account_sid";
            const string authToken = "your_twilio_auth_token";
            TwilioClient.Init(accountSid, authToken);

            var msg = MessageResource.Create(
                to: new PhoneNumber(toPhone),
                from: new PhoneNumber("your_twilio_phone_number"),
                body: message
            );
        }



    }

}