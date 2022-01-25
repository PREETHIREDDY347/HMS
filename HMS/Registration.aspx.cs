using HMS_BUSINESS;
using HMS_ENTITY;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HMS
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            PatientInfoBusiness patientInfoBusinessObj = new PatientInfoBusiness();
            PatientInfo patientInfoObj = new PatientInfo();
            patientInfoObj.PatientId = Convert.ToInt32(txtPatientId.Text);
            patientInfoObj.PatientName = txtPatientName.Text;
            patientInfoObj.Issue = txtIssue.Text;
            patientInfoObj.ReferralDoctor = txtReferralDoctor.Text;
            patientInfoObj.EmpId = Convert.ToInt32(txtEmployeeId.Text);
            patientInfoObj.EmpName = txtEmployeeName.Text;
            patientInfoObj.PatientStatus = txtPatientStatus.Text;
            patientInfoObj.PatientPwd = txtPatientPassword.Text;

            string msg = patientInfoBusinessObj.Insertion(patientInfoObj);
            lblResult.Text = msg;
            LoadData();
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            PatientInfoBusiness doctorInfoBusinessObj = new PatientInfoBusiness();
            DataTable dt = doctorInfoBusinessObj.Edit(int.Parse(txtPatientId.Text));

            txtPatientName.Text = dt.Rows[0][1].ToString();
            txtIssue.Text = dt.Rows[0][2].ToString();
            txtReferralDoctor.Text = dt.Rows[0][3].ToString();
            txtEmployeeId.Text = dt.Rows[0][4].ToString();
            txtEmployeeName.Text = dt.Rows[0][5].ToString();
            txtPatientStatus.Text = dt.Rows[0][6].ToString();
            txtPatientPassword.Text = dt.Rows[0][7].ToString();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            PatientInfoBusiness patientInfoBusinessObj = new PatientInfoBusiness();
            PatientInfo patientInfoObj = new PatientInfo();
            patientInfoObj.PatientId = Convert.ToInt32(txtPatientId.Text);
            patientInfoObj.PatientName = txtPatientName.Text;
            patientInfoObj.Issue = txtIssue.Text;
            patientInfoObj.ReferralDoctor = txtReferralDoctor.Text;
            patientInfoObj.EmpId = Convert.ToInt32(txtEmployeeId.Text);
            patientInfoObj.EmpName = txtEmployeeName.Text;
            patientInfoObj.PatientStatus = txtPatientStatus.Text;
            patientInfoObj.PatientPwd = txtPatientPassword.Text;

            string msg = patientInfoBusinessObj.Updation(patientInfoObj);
            lblResult.Text = msg;

            LoadData();
       
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            PatientInfoBusiness patientInfoBusinessObj = new PatientInfoBusiness();
            string msg = patientInfoBusinessObj.Deletion(int.Parse(txtPatientId.Text));
            lblResult.Text = msg;

            LoadData();

        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            PatientInfoBusiness patientInfoBusinessObj = new PatientInfoBusiness();
            string msg = patientInfoBusinessObj.Reset();
            lblResult.Text = msg;

            LoadData();
        }
        public void LoadData()
        {
            PatientInfoBusiness patientInfoBusinessObj = new PatientInfoBusiness();
            DataTable dt = patientInfoBusinessObj.Selection();
            gvPatientInfo.DataSource = dt;
            gvPatientInfo.DataBind();
        }
    }
}