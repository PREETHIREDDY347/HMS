using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HMS
{
    public partial class AdminRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtSecurityCode.Text) == 3467 && txtSecurityPassword.Text == "Sprint_1")
            {
                Response.Redirect("~/Administration.aspx");
            }
            else
            {
                lblResult.Text = "Unauthorized Access";
            }
        }
    }
}