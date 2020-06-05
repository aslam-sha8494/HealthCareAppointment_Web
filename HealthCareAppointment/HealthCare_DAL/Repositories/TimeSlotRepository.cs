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
    public class TimeSlotRepository : Repository<TimeSlot>, ITimeSlotRepository
    {
        public TimeSlotRepository(ApplicationDbContext context)
            : base(context)
        {
        }
        public async Task<IEnumerable<TimeSlot>> GetAllTimeSlot()
        {
            return await ApplicationDbContext.TimeSlot.ToListAsync();
        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return Context as ApplicationDbContext; }
        }
    }
}