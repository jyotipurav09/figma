

using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace HospitalStigma.Data1
{
    public class HospitalDbContext: DbContext
    {
        public HospitalDbContext(DbContextOptions<HospitalDbContext> options) : base(options)
        {
        }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Staff> Staffs { get; set; }

    }
}
