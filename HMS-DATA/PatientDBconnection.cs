using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using HMS_ENTITY;
using System.Data.SqlClient;

namespace HMS_DATA
{
    public class PatientDBconnection
    {
        string sqlConnectionStr = "Data Source=LAPTOP-0FA4IHE8;Initial Catalog=HMS;Integrated Security=True";
        public string InsertPatientInfo(PatientInfo patientInfoObj)
        {
            DataTable dataTableObj = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter sqlDataAdapterObj = new SqlDataAdapter("Insert into PatientInfo values(" + patientInfoObj.PatientId + ",'" + patientInfoObj.PatientName + "','" + patientInfoObj.Issue + "','" + patientInfoObj.ReferralDoctor + "'," + patientInfoObj.EmpId + ",'" + patientInfoObj.EmpName + "','" + patientInfoObj.PatientStatus + "','" + patientInfoObj.PatientPwd + "')", sqlConnectionObj);
            sqlDataAdapterObj.Fill(dataTableObj);
            return "Patient Information Inserted Successfully";
        }

        public string UpdatePatientInfo(PatientInfo patientInfoObj)
        {
            DataTable dataTableObj = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter sqlDataAdapterObj = new SqlDataAdapter("Update PatientInfo set PatientName='" + patientInfoObj.PatientName + "',Issue='" + patientInfoObj.Issue + "',ReferralDoctor='" + patientInfoObj.ReferralDoctor + "',EmpId=" + patientInfoObj.EmpId + ",EmpName='" + patientInfoObj.EmpName + "',PatientStatus='" + patientInfoObj.PatientStatus + "',PatientPwd='" + patientInfoObj.PatientPwd + "' where PatientId=" + patientInfoObj.PatientId + "", sqlConnectionObj);
            sqlDataAdapterObj.Fill(dataTableObj);
            return "Patient Information Updated Successfully";
        }
        public DataTable EditPatientInfoById(int PatientId)
        {
            DataTable dataTableObj = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter sqlDataAdapterObj = new SqlDataAdapter(" select*from PatientInfo where PatientId=" + PatientId + "", sqlConnectionObj);
            sqlDataAdapterObj.Fill(dataTableObj);
            return dataTableObj;
        }
        public DataTable SelectPatientInfo()
        {
            DataTable dataTableObj = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter sqlDataAdapterObj = new SqlDataAdapter(" select*from PatientInfo", sqlConnectionObj);
            sqlDataAdapterObj.Fill(dataTableObj);
            return dataTableObj;
        }
        public string DeletePatientInfoById(int PatientId)
        {
            DataTable dataTableObj = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter sqlDataAdapterObj = new SqlDataAdapter(" Delete from PatientInfo where PatientId=" + PatientId + "", sqlConnectionObj);
            sqlDataAdapterObj.Fill(dataTableObj);
            return "Deleted Successfully";
        }
        public string ResetAll()
        {
            DataTable dataTableObj = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter sqlDataAdapterObj = new SqlDataAdapter(" truncate table PatientInfo ", sqlConnectionObj);
            sqlDataAdapterObj.Fill(dataTableObj);
            return "Reset Successfully";
        }
        public DataTable LoginCheck(int PatientId, string PatientPwd)
        {
            DoctorInfo doctorInfo = new DoctorInfo();
            DataTable dt = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter adp = new SqlDataAdapter("select PatientName,Issue,ReferralDoctor,EmpId,EmpName,PatientStatus,DoctName,ConsultFee from PatientInfo,DoctorInfo where DoctorInfo.DoctType=PatientInfo.Issue and PatientId ='" + PatientId + "' and PatientPwd='" + PatientPwd + "'", sqlConnectionObj);
            adp.Fill(dt);
            return dt;


        }

    }
}
