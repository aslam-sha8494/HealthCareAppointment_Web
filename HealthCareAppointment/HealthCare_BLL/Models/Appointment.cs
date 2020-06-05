using HealthCareAppointment.HealthCare_BLL.AccountModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HealthCareAppointment.HealthCare_BLL.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }

        [Required]
        [Display(Name = "Appointment Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MMM/yyyy}")]
        public DateTime AppointmentDate { get; set; }

        public int Status { get; set; }

        [NotMapped]
        public ICollection<States> StateList { get; set; }

        [Required]
        [Display(Name = "State")]
        public int StateId { get; set; }
        [ForeignKey("StateId")]

        public States States { get; set; }

        [NotMapped]
        public ICollection<Locations> LocationList { get; set; }

        [Required]
        [Display(Name = "Location")]
        public int LocationId { get; set; }
        [ForeignKey("LocationId")]

        public Locations Locations { get; set; }

        [NotMapped]
        public ICollection<Doctors> DoctorList { get; set; }

        [Required]
        [Display(Name = "Doctors")]
        public int DoctorId { get; set; }
        [ForeignKey("DoctorId")]

        public Doctors Doctors { get; set; }

        [NotMapped]
        public ICollection<TimeSlot> TimeSlotList { get; set; }

        [Required]
        [Display(Name = "TimeSlot")]
        public int TimeSlotId { get; set; }
        [ForeignKey("TimeSlotId")]

        public TimeSlot TimeSlot { get; set; }

        [NotMapped]
        public ICollection<Specialization> SpecializationList { get; set; }

        [Required]
        [Display(Name = "Specialization")]
        public int SpecializationId { get; set; }
        [ForeignKey("SpecializationId")]
        public Specialization Specialization { get; set; }

        [NotMapped]
        public ICollection<UserRegisters> UserRegisterList { get; set; }

        public int RegisterId { get; set; }
        [ForeignKey("RegisterId")]
        public UserRegisters UserRegisters { get; set; }

        public Appointment()
        {
            StateList = new Collection<States>();
            LocationList = new Collection<Locations>();
            DoctorList = new Collection<Doctors>();
            TimeSlotList = new Collection<TimeSlot>();
            SpecializationList = new Collection<Specialization>();
            UserRegisterList = new Collection<UserRegisters>();
        }
    }
}