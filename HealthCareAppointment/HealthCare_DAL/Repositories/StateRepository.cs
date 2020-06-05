using HealthCareAppointment.HealthCare_BLL.Models;
using HealthCareAppointment.HealthCare_BLL.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace HealthCareAppointment.HealthCare_DAL.Repositories
{
    public class StateRepository : Repository<States>, IStateRepository
    {
        public StateRepository(ApplicationDbContext context)
            : base(context)
        {
        }
        public async Task<IEnumerable<States>> GetStates()
        {
            return await ApplicationDbContext.States.Include(c=>c.StateId).ToListAsync();
        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return Context as ApplicationDbContext; }
        }
    }
}