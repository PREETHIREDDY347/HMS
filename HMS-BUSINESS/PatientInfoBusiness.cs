using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS_DATA;
using System.Data;
using HMS_ENTITY;

namespace HMS_BUSINESS
{
    public class PatientInfoBusiness
    {
        public string Insertion(PatientInfo patientInfoObj)
        {
            PatientDBconnection doctorDBconnectionObj = new PatientDBconnection();
            string msg = doctorDBconnectionObj.InsertPatientInfo(patientInfoObj);
            return msg;
        }
        public string Updation(PatientInfo patientInfoObj)
        {
            PatientDBconnection doctorDBConnectionObj = new PatientDBconnection();
            string msg = doctorDBConnectionObj.UpdatePatientInfo(patientInfoObj);
            return msg;
        }
        public DataTable Edit(int PatientId)
        {
            PatientDBconnection doctorDBConnectionObj = new PatientDBconnection();
            DataTable dt = doctorDBConnectionObj.EditPatientInfoById(PatientId);
            return dt;
        }
        public DataTable Selection()
        {
            PatientDBconnection doctorDBConnectionObj = new PatientDBconnection();
            DataTable dt = doctorDBConnectionObj.SelectPatientInfo();
            return dt;
        }
        public string Deletion(int PatientId)
        {
            PatientDBconnection doctorDBConnectionObj = new PatientDBconnection();
            string msg = doctorDBConnectionObj.DeletePatientInfoById(PatientId);
            return msg;
        }
        public string Reset()
        {
            PatientDBconnection patientDBConnectionObj = new PatientDBconnection();
            string msg = patientDBConnectionObj.ResetAll();
            return msg;
        }
        public DataTable LoginCheck(int PatientId, string PatientPwd)
        {
            PatientDBconnection patientInfoDBConnection = new PatientDBconnection();
            DataTable dt = patientInfoDBConnection.LoginCheck(PatientId, PatientPwd);
            return dt;
        }
    }
}
