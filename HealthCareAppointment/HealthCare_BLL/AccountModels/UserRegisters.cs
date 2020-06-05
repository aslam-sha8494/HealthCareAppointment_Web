using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.ObjectModel;

namespace HealthCareAppointment.HealthCare_BLL.AccountModels
{
    public class UserRegisters
    {
        [Key]
        [Required]
        public int RegisterId { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.")]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [NotMapped]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "The {0} must be at least {2} characters long.")]
        public string PhoneNumber { get; set; }

        [NotMapped]
        public ICollection<UserRoles> RoleList { get; set; }

        public int RoleId { get; set; }
        [ForeignKey("RoleId")]

        public UserRoles UserRoles { get; set; }

        public UserRegisters()
        {
            RoleList = new Collection<UserRoles>();
        }

    }
}