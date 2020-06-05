using HealthCareAppointment.HealthCare_BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareAppointment.HealthCare_BLL.Repositories
{
    public interface IAppointmentRepository : IRepository<Appointment>
    {
        Task<IEnumerable<Appointment>> GetAllAppointments();

        Task<IEnumerable<Appointment>> GetAppointmentByPatientId(int _iPatientid);

        Task<IEnumerable<Appointment>> GetAppointmentByDoctorId(int _iDoctorid);

        Task<Appointment> GetAppointmentById(int _Appointmentid);       

        Appointment GetAppointment(int id);
    }
}
