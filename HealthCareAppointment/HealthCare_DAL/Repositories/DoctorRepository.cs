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
    public class DoctorRepository : Repository<Doctors>, IDoctorRepository
    {
        public DoctorRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return Context as ApplicationDbContext; }
        }

        public async Task<IEnumerable<Doctors>> GetAllDoctors()
        {
            return await ApplicationDbContext.Doctors
                .Include(c => c.States)
                .Include(c => c.Locations)
                .Include(c => c.Specialization)
                .ToListAsync();
        }
    }
}