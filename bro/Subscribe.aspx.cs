using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
                smtp.Credentials = new NetworkCredential("siyabongmelissa@gmail.com", "gyeabsmhnmivqlqw");
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
       


    }

}