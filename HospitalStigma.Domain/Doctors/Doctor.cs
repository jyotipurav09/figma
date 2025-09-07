

using HospitalStigma.Domain.Appointments;
using HospitalStigma.Domain.Patients;
using System.ComponentModel.DataAnnotations;

namespace HospitalStigma.Domain.Doctors
{
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }

        [Required,MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(100)]
        public string Specialization { get; set; } = string.Empty;

        [MaxLength(20)]
        public string Phone { get; set; } = string.Empty;

        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
        public ICollection<Patient> Patients { get; set; } = new List<Patient>();   






    }
}
