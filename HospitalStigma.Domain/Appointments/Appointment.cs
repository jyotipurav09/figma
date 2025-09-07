using HospitalStigma.Domain.Doctors;
using HospitalStigma.Domain.Patients;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalStigma.Domain.Appointments
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }

        [ForeignKey("Patient")]
        public int PatientId { get; set; }

        public Patient Patient { get; set; }

        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }
       // public Doctor Doctor { get; set; }

        [Required]
        public DateTime AppointmentDate { get; set; }

        [MaxLength(200)]
        public string Reason { get; set; } = string.Empty;

        public string Status { get; set; } = "Scheduled"; 






    }
}
