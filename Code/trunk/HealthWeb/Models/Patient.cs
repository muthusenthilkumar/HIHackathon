using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HealthWeb.Models
{
    public class Patient
    {
        public int PatientId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(50)]        
        public string Name { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Contact Person is required")]
        [DisplayName("Contact Person")]
        [StringLength(20)]
        public string ContactPerson { get; set; }

        [Required(ErrorMessage = "Emergency Contact No is required")]
        [DisplayName("Emergency Contact No")]
        [StringLength(10)]
        public string EmergencyContactNo { get; set; }

        [Required(ErrorMessage = "Admission Date is required")]
        [DisplayName("Admission Date")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}",
               ApplyFormatInEditMode = true)]
        public DateTime AdmissionDate { get; set; }

        [Required(ErrorMessage = "Doctor Name is required")]
        [DisplayName("Doctor")]
        public string DoctorId { get; set; }

        [DisplayName("Health Summary")]
        public string HealthSummary { get; set; }

        public List<Doctor> DoctorList { get; set; }        

    }
}