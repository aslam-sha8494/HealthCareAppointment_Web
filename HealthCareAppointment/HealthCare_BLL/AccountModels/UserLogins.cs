using System.ComponentModel.DataAnnotations;

namespace HealthCareAppointment.HealthCare_BLL.AccountModels
{
    public class UserLogins
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}