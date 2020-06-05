using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using HealthCareAppointment.HealthCare_BLL.AccountModels;
using HealthCareAppointment.HealthCare_BLL.Repositories;

namespace HealthCareAppointment.HealthCare_DAL.Repositories
{
    public class RegisterRepository : Repository<UserRegisters>, IRegisterRepository
    {
        public RegisterRepository(ApplicationDbContext context)
            : base(context)
        {
        }
        public async Task<IEnumerable<UserRegisters>> GetRegisters(int Id)
        {
            return await ApplicationDbContext.UserRegisters.Where(n => n.RegisterId == Id).ToListAsync();
        }

        public async Task<IEnumerable<UserRegisters>> GetDoctorBasedOnRole(int _iRoleId)
        {
            return await ApplicationDbContext.UserRegisters.Where(n => n.RoleId == _iRoleId).ToListAsync();
        }

        public async Task<UserRegisters> ValidateLoginUsers(UserRegisters UserLoginDetails)
        {
            return await ApplicationDbContext.UserRegisters.Where(n => n.UserName == UserLoginDetails.UserName && n.Password == UserLoginDetails.Password).FirstOrDefaultAsync();
        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return Context as ApplicationDbContext; }
        }
    }
}