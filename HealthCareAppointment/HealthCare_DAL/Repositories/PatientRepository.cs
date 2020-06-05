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
    public class PatientRepository : Repository<Patient>, IPatientRepository
    {
        public PatientRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return Context as ApplicationDbContext; }
        }

        public async Task<IEnumerable<Patient>> GetAllPatients()
        {
            return await ApplicationDbContext.Patient
                .Include(c => c.States)
                .Include(c => c.Locations)
                .ToListAsync();
        }
    }
}