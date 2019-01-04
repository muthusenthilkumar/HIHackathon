using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HealthWeb.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Contact No is required")]
        [DisplayName("Contact No")]
        [StringLength(10)]
        public string ContactNo { get; set; }

        [DisplayName("Alternate Contact No")]
        [StringLength(10)]
        public string AlternateContactNo { get; set; }

        [StringLength(16)]
        public string Speciality { get; set; }
        
        [DisplayName("Qualification Summary")]
        [StringLength(100)]
        public string QualificationSummary { get; set; }
    }
}