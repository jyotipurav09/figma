

using System.ComponentModel.DataAnnotations;

namespace HospitalStigma.Domain.Staffs
{
    public class Staff
    {
        [Key]
        public int StaffId { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required, MaxLength(100)]
        public string Role { get; set; } = string.Empty; // e.g., Nurse, Receptionist

        [MaxLength(20)]
        public string Shift { get; set; } = string.Empty; // e.g., Morning, Evening


        [MaxLength(20)]
        public string Phone { get; set; } = string.Empty;


    }
}
