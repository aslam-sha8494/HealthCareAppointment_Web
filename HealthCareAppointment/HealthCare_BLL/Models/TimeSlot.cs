using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HealthCareAppointment.HealthCare_BLL.Models
{
    public class TimeSlot
    {
        [Key]
        [Required]
        public int TimeSlotId { get; set; }

        [Required]
        [Display(Name = "Slot Time")]
        public string SlotTime { get; set; }
    }
}