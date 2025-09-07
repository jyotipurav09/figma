

using HospitalStigma.Domain.Patients;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalStigma.Domain.Bills
{
    public class Bill
    {
        [Key]
        public int BillId { get; set; }

        [ForeignKey("Patient")]
        public int PatientId { get; set; }
     //   public Patient Patient { get; set; }

        [Required]

        public decimal Amount { get; set; }

        [Required]
        public DateTime BillDate { get; set; } = DateTime.Now;

        [MaxLength(100)]

        public string PaymentStatus { get; set; } = "Unpaid";


    }
}
