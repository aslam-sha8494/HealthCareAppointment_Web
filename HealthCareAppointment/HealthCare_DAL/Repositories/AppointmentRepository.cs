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
    public class AppointmentRepository : Repository<Appointment>, IAppointmentRepository
    {
        public AppointmentRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return Context as ApplicationDbContext; }
        }

        public async Task<IEnumerable<Appointment>> GetAllAppointments()
        {
            return await ApplicationDbContext.Appointment
                .Include(c => c.States)
                .Include(c => c.Locations)
                .Include(c => c.Locations)
                .Include(c => c.TimeSlot)
                .Include(c => c.Doctors)
                .Include(c => c.Specialization)
                .Include(c=>c.UserRegisters)
                .ToListAsync();
        }

        public async Task<IEnumerable<Appointment>> GetAppointmentByPatientId(int _iPatientId)
        {
            return await ApplicationDbContext.Appointment
                .Where(d => d.RegisterId == _iPatientId)
                .Include(c => c.States)
                .Include(c => c.Locations)
                .Include(c => c.Locations)
                .Include(c => c.TimeSlot)
                .Include(c => c.Doctors)
                .Include(c => c.Specialization)
                .Include(c => c.UserRegisters)
                .ToListAsync();
        }

        public async Task<IEnumerable<Appointment>> GetAppointmentByDoctorId(int _iDoctorid)
        {
            return await ApplicationDbContext.Appointment
                .Where(d => d.DoctorId == _iDoctorid)
                .Include(c => c.States)
                .Include(c => c.Locations)
                .Include(c => c.Locations)
                .Include(c => c.TimeSlot)
                .Include(c => c.Doctors)
                .Include(c => c.Specialization)
                .Include(c => c.UserRegisters)
                .ToListAsync();
        }

        public async Task<Appointment> GetAppointmentById(int _Appointmentid)
        {
            return await ApplicationDbContext.Appointment
                .Where(d => d.AppointmentId == _Appointmentid)
                .Include(c => c.States)
                .Include(c => c.Locations)
                .Include(c => c.Locations)
                .Include(c => c.TimeSlot)
                .Include(c => c.Doctors)
                .Include(c => c.Specialization)
                .Include(c => c.UserRegisters)
                .FirstOrDefaultAsync();
        }

        public Appointment GetAppointment(int id)
        {
            return ApplicationDbContext.Appointment.Find(id);
        }
    }
}