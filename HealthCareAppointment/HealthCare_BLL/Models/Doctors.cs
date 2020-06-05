using HealthCareAppointment.HealthCare_BLL.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthCareAppointment.HealthCare_BLL.Models
{
    public class Doctors
    {
        [Key]
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        [NotMapped]
        public ICollection<States> StateList { get; set; }

        public int StateId { get; set; }
        [ForeignKey("StateId")]

        public States States { get; set; }

        [NotMapped]
        public ICollection<Locations> LocationList { get; set; }

        public int LocationId { get; set; }
        [ForeignKey("LocationId")]

        public Locations Locations { get; set; }

        [NotMapped]
        public ICollection<Specialization> SpecializationList { get; set; }

        public int SpecializationId { get; set; }
        [ForeignKey("SpecializationId")]
        public Specialization Specialization { get; set; }

        public Gender Gender { get; set; }
        public int Experience { get; set; }
        public string PhoneNumber { get; set; }

        public string Email { get; set; }
        public bool IsAvailable { get; set; }
        public string Address { get; set; }

        public Doctors()
        {
            SpecializationList = new Collection<Specialization>();
            StateList = new Collection<States>();
            LocationList = new Collection<Locations>();
        }

    }
}