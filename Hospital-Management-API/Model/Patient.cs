using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital_Management_API.Model
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public DateTime RegisterDate { get; set; }
        public int PatientAge { get; set; }
        public string Department { get; set; }
        public string DoctorName { get; set; }
        public string DoctorFee { get; set; }
        public string CreatedBy { get; set; }

    }
}
