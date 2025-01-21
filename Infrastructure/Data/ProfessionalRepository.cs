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
    public class ProfessionalRepository:IProfessionalRepository
    {
        private readonly BontleContext _context;

        public ProfessionalRepository(BontleContext context)
        {
            _context=context;
        }

        public async Task<Professional> GetProfessionalByIdAsync(int id)
        {
            return await  _context.Professionals
                .Include(p=>p.User)
                .FirstOrDefaultAsync(p=>p.ProfessionalId==id);
        }

        public async Task<IReadOnlyList<Professional>> GetProfessionalsAsync()
        {   
            return await _context.Professionals
                   .Include(p=>p.User)
                   .ToListAsync();
        }
    }
}