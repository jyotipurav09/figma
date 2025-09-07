

using HospitalStigma.Domain.Appointments;
using HospitalStigma.Domain.Bills;
using HospitalStigma.Domain.Doctors;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalStigma.Domain.Patients
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }

        [Required, MaxLength(10)]
        public string Gender { get; set; } = string.Empty;

        [MaxLength(200)]

        public string Address { get; set; } = string.Empty;

        public string disease { get; set; } = string.Empty;

        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }
       //public Doctor Doctor { get; set; }

        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

        public ICollection<Bill> Bills { get; set; } = new List<Bill>();





















    }
}
