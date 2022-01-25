using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using HMS_ENTITY;

namespace HMS_DATA
{
    public class DoctorDBconnection
    {
        string sqlConnectionStr = "Data Source=LAPTOP-0FA4IHE8;Initial Catalog=HMS;Integrated Security=True";
        public string InsertDoctInfo(DoctorInfo doctInfoObj)
        {
            DataTable dataTableObj = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter sqlDataAdapterObj = new SqlDataAdapter("Insert into DoctorInfo values(" + doctInfoObj.DoctId + ",'" + doctInfoObj.DoctName + "','" + doctInfoObj.DoctType + "','" + doctInfoObj.DoctMaster + "'," + doctInfoObj.ConsultFee + ")", sqlConnectionObj);
            sqlDataAdapterObj.Fill(dataTableObj);
            return "Doctor Information Inserted Successfully";
        }
        public string UpdateDoctInfo(DoctorInfo doctInfoObj)
        {
            DataTable dataTableObj = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter sqlDataAdapterObj = new SqlDataAdapter("Update DoctorInfo set DoctName='" + doctInfoObj.DoctName + "',DoctType='" + doctInfoObj.DoctType + "',DoctMaster='" + doctInfoObj.DoctMaster + "',ConsultFee=" + doctInfoObj.ConsultFee + " where DoctId=" + doctInfoObj.DoctId + "", sqlConnectionObj);
            sqlDataAdapterObj.Fill(dataTableObj);
            return "Doctor Information Updated Successfully";
        }
        public DataTable EditDoctInfoByID(int DoctId)
        {
            DataTable dataTableObj = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter sqlDataAdapterObj = new SqlDataAdapter(" select*from DoctorInfo where DoctId=" + DoctId + "", sqlConnectionObj);
            sqlDataAdapterObj.Fill(dataTableObj);
            return dataTableObj;
        }
        public DataTable SelectDoctInfo()
        {
            DataTable dataTableObj = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter sqlDataAdapterObj = new SqlDataAdapter(" select*from DoctorInfo order by DoctId", sqlConnectionObj);
            sqlDataAdapterObj.Fill(dataTableObj);
            return dataTableObj;
        }
        public string DeleteDoctInfoByID(int DoctId)
        {
            DataTable dataTableObj = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter sqlDataAdapterObj = new SqlDataAdapter(" Delete from DoctorInfo where DoctId=" + DoctId + "", sqlConnectionObj);
            sqlDataAdapterObj.Fill(dataTableObj);
            return "Deleted Successfully";
        }
        public DataTable LoginCheck(int DoctId, string DoctName)
        {

            DataTable dt = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter adp = new SqlDataAdapter("select DoctName,DoctType,DoctMaster,ConsultFee from DoctorInfo where DoctId=" + DoctId + " and DoctName='" + DoctName + "'", sqlConnectionObj);
            adp.Fill(dt);
            return dt;


        }
    }
}
