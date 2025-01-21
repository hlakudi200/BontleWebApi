using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Models.Entity;

namespace core.Interfaces
{
    public interface IAppointmentRepository
    {
        Task<Appointment> GeAppointmentByIdAsync(int id);
        Task<IReadOnlyList<Appointment>> GetAppointmentsAsync();
    }
}