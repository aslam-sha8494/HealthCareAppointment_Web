using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HealthCareAppointment.HealthCare_BLL.Models
{
    public class States
    {
        [Key]
        [Required]
        public int StateId { get; set; }

        [Required]
        [Display(Name = "State Name")]
        public string StateName { get; set; }
    }
}