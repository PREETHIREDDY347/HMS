using HMS_BUSINESS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HMS
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            DoctorInfoBusiness doctorInfoBusiness = new DoctorInfoBusiness();
            DataTable dtLogin = doctorInfoBusiness.LoginCheck(int.Parse(txtDoctorID.Text), txtPassword.Text);
            if (dtLogin.Rows.Count > 0)
            {
                gvDoctorInfo.DataSource = dtLogin;
                gvDoctorInfo.DataBind();
            }
            else
            {
                lblResult.Text = "Account does not exist!!! Register";
            }
        }
    }
}