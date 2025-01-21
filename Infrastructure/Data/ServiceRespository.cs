using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Interfaces;
using core.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ServiceRespository:IServiceRepository
    {
        private readonly BontleContext _context;

        public ServiceRespository(BontleContext context)
        {     
              _context=context;

        }

        public async Task AddServiceAsync(Service service)
        {
           await _context.Services.AddAsync(service);
           await _context.SaveChangesAsync();
        }

        public async Task DeleteServiceAsync(Service service)
        {
            _context.Services.Remove(service);
            await _context.SaveChangesAsync();
        }

        public async Task<Service> GetServiceByIdAsync(int Id)
        {
            return await _context.Services.FindAsync(Id);
        }

        public async Task<IReadOnlyList<Service>> GetServicesAsync()
        {
            return await _context.Services
               //.Include(p=>p.Professional)
               .ToListAsync();
        }

        public async Task UpdateUserAsync(Service service)
        {
           _context.Services.Update(service);
           await _context.SaveChangesAsync();
        }
    }
}