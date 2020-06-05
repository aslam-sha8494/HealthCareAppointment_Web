using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using HealthCareAppointment.HealthCare_BLL.AccountModels;
using HealthCareAppointment.HealthCare_BLL.Repositories;

namespace HealthCareAppointment.HealthCare_DAL.Repositories
{
    public class RoleRepository : Repository<UserRoles>, IRoleRepository
    {
        public RoleRepository(ApplicationDbContext context)
            : base(context)
        {
        }
        public IEnumerable<UserRoles> GetRoles()
        {
            return ApplicationDbContext.UserRoles.ToList();
        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return Context as ApplicationDbContext; }
        }
    }
}