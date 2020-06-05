using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCareAppointment.HealthCare_BLL.Repositories;

namespace HealthCareAppointment.HealthCare_BLL
{
    public interface IUnitOfWork : IDisposable
    {
        IRegisterRepository UserRegisters { get; set; }
        IRoleRepository UserRoles { get; set; }

        IAppointmentRepository Appointment { get; }

        IDoctorRepository Doctors { get; }
        IPatientRepository Patient { get; }
        ISpecializationRepository Specialization { get; }
        IlocationRepository Locations { get; }
        IStateRepository States { get; }

        ITimeSlotRepository TimeSlot { get; }
        void Complete();
    }
}
