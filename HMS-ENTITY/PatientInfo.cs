using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_ENTITY
{
     public class PatientInfo
    {
        public int PatientId{ get; set; }
        public string PatientName { get; set; }
        public string Issue { get; set; }
        public string ReferralDoctor { get; set; }
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string PatientStatus { get; set; }
        public string PatientPwd { get; set; }
    }
}
