using HealthCareAppointment.HealthCare_BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareAppointment.HealthCare_BLL.Repositories
{
    public interface ITimeSlotRepository : IRepository<TimeSlot>
    {
        Task<IEnumerable<TimeSlot>> GetAllTimeSlot();
    }
}
