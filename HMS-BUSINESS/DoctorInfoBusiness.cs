using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using HMS_DATA;
using HMS_ENTITY;

namespace HMS_BUSINESS
{
    public class DoctorInfoBusiness
    {
        public string Insertion(DoctorInfo doctorInfoObj)
        {
            DoctorDBconnection doctorDBConnectionObj = new DoctorDBconnection();
            string msg = doctorDBConnectionObj.InsertDoctInfo(doctorInfoObj);
            return msg;
        }
        public string Updation(DoctorInfo doctorInfoObj)
        {
            DoctorDBconnection doctorDBConnectionObj = new DoctorDBconnection();
            string msg = doctorDBConnectionObj.UpdateDoctInfo(doctorInfoObj);
            return msg;
        }
        public DataTable Edit(int DoctId)
        {
            DoctorDBconnection doctorDBConnectionObj = new DoctorDBconnection();
            DataTable dt = doctorDBConnectionObj.EditDoctInfoByID(DoctId);
            return dt;
        }
        public DataTable Selection()
        {
            DoctorDBconnection doctorDBConnectionObj = new DoctorDBconnection();
            DataTable dt = doctorDBConnectionObj.SelectDoctInfo();
            return dt;
        }
        public string Deletion(int DoctId)
        {
            DoctorDBconnection doctorDBConnectionObj = new DoctorDBconnection();
            string msg = doctorDBConnectionObj.DeleteDoctInfoByID(DoctId);
            return msg;
        }
        public DataTable LoginCheck(int DoctId, string DoctName)
        {
            DoctorDBconnection doctorInfoDBConnection = new DoctorDBconnection();
            DataTable dt = doctorInfoDBConnection.LoginCheck(DoctId, DoctName);
            return dt;
        }

    }
}
