using HealthCareAppointment.HealthCare_BLL.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthCareAppointment.HealthCare_BLL.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public Gender Sex { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }

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
        public string Address { get; set; }
        public DateTime DateTime { get; set; }

        public int Age
        {
            get
            {
                var now = DateTime.Today;
                var age = now.Year - BirthDate.Year;
                if (BirthDate > now.AddYears(-age)) age--;
                return age;
            }

        }
        
        public Patient()
        {
            StateList = new Collection<States>();
            LocationList = new Collection<Locations>();
        }
    }
}