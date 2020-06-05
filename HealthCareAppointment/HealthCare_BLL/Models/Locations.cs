using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HealthCareAppointment.HealthCare_BLL.Models
{
    public class Locations
    {
        [Key]
        [Required]
        public int LocationId { get; set; }

        [Required]
        [Display(Name = "Location Name")]
        public string LocationName { get; set; }

        [NotMapped]
        public ICollection<States> StateList { get; set; }

        public int StateId { get; set; }
        [ForeignKey("StateId")]

        public States States { get; set; }

        public Locations()
        {
            StateList = new Collection<States>();
        }

    }
}