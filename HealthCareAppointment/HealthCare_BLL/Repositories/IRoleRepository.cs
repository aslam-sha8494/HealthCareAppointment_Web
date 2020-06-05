using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCareAppointment.HealthCare_BLL.AccountModels;

namespace HealthCareAppointment.HealthCare_BLL.Repositories
{
    public interface IRoleRepository : IRepository<UserRoles>
    {
        IEnumerable<UserRoles> GetRoles();
    }
}
