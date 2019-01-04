using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthWeb.Models
{
    public class DoctorPatient
    {
        public List<Doctor> DoctorList { get; set; }
        public List<Patient> PatientList { get; set; }
    }
}