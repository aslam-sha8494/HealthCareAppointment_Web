using HealthCareAppointment.HealthCare_BLL.Models;
using HealthCareAppointment.HealthCare_BLL.AccountModels;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace HealthCareAppointment.HealthCare_DAL
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public virtual DbSet<UserRoles> UserRoles { get; set; }
        public virtual DbSet<UserRegisters> UserRegisters { get; set; }

        public virtual DbSet<Appointment> Appointment { get; set; }

        public virtual DbSet<Doctors> Doctors { get; set; }
        public virtual DbSet<Locations> Locations { get; set; }

        public virtual DbSet<States> States { get; set; }

        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<Specialization> Specialization { get; set; }

        public virtual DbSet<TimeSlot> TimeSlot { get; set; }

        public ApplicationDbContext()
            : base("HealthcareAppointmentConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

    }
}