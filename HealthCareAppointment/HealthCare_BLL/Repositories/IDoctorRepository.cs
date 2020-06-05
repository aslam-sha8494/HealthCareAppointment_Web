using HealthCareAppointment.HealthCare_BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareAppointment.HealthCare_BLL.Repositories
{
    public interface IDoctorRepository : IRepository<Doctors>
    {
        Task<IEnumerable<Doctors>> GetAllDoctors();
    }
}