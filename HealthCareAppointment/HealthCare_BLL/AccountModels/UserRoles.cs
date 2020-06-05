using System.ComponentModel.DataAnnotations;

namespace HealthCareAppointment.HealthCare_BLL.AccountModels
{
    public class UserRoles
    {
        [Key]
        public int RoleId { get; set; }

        [Display(Name = "Role Name")]
        public string RoleName { get; set; }

    }
}