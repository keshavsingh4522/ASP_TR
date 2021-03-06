using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsApplication
{
    public partial class NewsletterSignup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                ltMessage.Text = "Welcome to my Newsletter Signup page!";
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            //TODO: validate and save email to your data
            ltMessage.Text = "your email has been subscribed to our Newsletter!";
        }
    }
}