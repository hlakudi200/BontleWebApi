using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Interfaces;
using core.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class AvailabilityRepository : IAvailabilityRepository
    {   
        public readonly BontleContext _context;
        public AvailabilityRepository(BontleContext Context)
        {
            _context=Context;
        }

        public async Task<IReadOnlyList<Availability>> GetAvailabilitiesAsync()
        {
            return await _context.Availabilities.ToListAsync();
        }

        public async Task<Availability> GetAvailabityByIdAsync(int Id)
        {
            return await _context.Availabilities.FindAsync(Id);
        }
    }
}