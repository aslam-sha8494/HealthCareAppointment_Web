using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using HealthCareAppointment.HealthCare_BLL.AccountModels;

namespace HealthCareAppointment.HealthCare_BLL.Repositories
{
    public interface IRegisterRepository : IRepository<UserRegisters>
    {
        Task<IEnumerable<UserRegisters>> GetRegisters(int Id);

        Task<IEnumerable<UserRegisters>> GetDoctorBasedOnRole(int _iRoleId);

        Task<UserRegisters> ValidateLoginUsers(UserRegisters UserLoginDetails);
    }
}