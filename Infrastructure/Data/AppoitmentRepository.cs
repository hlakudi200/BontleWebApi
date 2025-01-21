using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Interfaces;
using core.Models.Entity;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class AppoitmentRepository : IAppointmentRepository
    {   

        private readonly BontleContext _context;

        public AppoitmentRepository( BontleContext Context)
        {
           _context=Context;
        }

        public async Task<Appointment> GeAppointmentByIdAsync(int id)
        {
            return await _context.Appointments.FindAsync(id);
        }

        public async Task<IReadOnlyList<Appointment>> GetAppointmentsAsync()
        {
            return await _context.Appointments.ToListAsync();
        }
    }
}