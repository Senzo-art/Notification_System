using System;
using System.Collections.Generic;
using System.Linq;
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
            string email = txtEmail.Text;
            bool notifyByEmail = chkEmail.Checked;
            bool notifyBySMS = chkSMS.Checked;
            bool notifyByPush = chkPush.Checked;

            // Example: Store the subscription or display a message
            string summary = $"Subscribed {email} to: "
                + (notifyByEmail ? "Email " : "")
                + (notifyBySMS ? "SMS " : "")
                + (notifyByPush ? "Push " : "");

            // For now, you can use this to debug
            Response.Write("<script>alert('" + summary + "');</script>");
        }


    }

}