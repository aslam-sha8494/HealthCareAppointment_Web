using HealthCareAppointment.HealthCare_BLL;
using HealthCareAppointment.HealthCare_BLL.Models;
using HealthCareAppointment.HealthCare_BLL.Repositories;
using HealthCareAppointment.HealthCare_DAL.Repositories;

namespace HealthCareAppointment.HealthCare_DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _applicationDbContext;

        //public UnitOfWork()
        //{
        //    UserRegisters = new RegisterRepository(_applicationDbContext);
        //    UserRoles = new RoleRepository(_applicationDbContext);

        //    Appointment = new AppointmentRepository(_applicationDbContext);
        //    Doctors = new DoctorRepository(_applicationDbContext);
        //    Patient = new PatientRepository(_applicationDbContext);
        //    Specialization = new SpecializationRepository(_applicationDbContext);
        //    TimeSlot = new TimeSlotRepository(_applicationDbContext);
        //}
        public UnitOfWork(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
            UserRegisters = new RegisterRepository(_applicationDbContext);
            UserRoles = new RoleRepository(_applicationDbContext);
            Locations = new LocationRepository(_applicationDbContext);
            States = new StateRepository(_applicationDbContext);
            Appointment = new AppointmentRepository(_applicationDbContext);
            Doctors = new DoctorRepository(_applicationDbContext);
            Patient = new PatientRepository(_applicationDbContext);
            Specialization = new SpecializationRepository(_applicationDbContext);
            TimeSlot = new TimeSlotRepository(_applicationDbContext);
        }

        public IRegisterRepository UserRegisters { get; set; }
        public IRoleRepository UserRoles { get; set; }

        public IlocationRepository Locations { get; private set; }

        public IStateRepository States { get; private set; }

        public IAppointmentRepository Appointment { get; private set; }
        public IDoctorRepository Doctors { get; private set; }
        public IPatientRepository Patient { get; private set; }
        public ISpecializationRepository Specialization { get; private set; }

        public ITimeSlotRepository TimeSlot { get; private set; }

        public void Complete()
        {
            _applicationDbContext.SaveChanges();
        }

        public void Dispose()
        {
            _applicationDbContext.Dispose();
        }
    }
}