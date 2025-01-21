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
    public class ProfessionalRepository : IProfessionalRepository
    {
        private readonly BontleContext _context;

        public ProfessionalRepository(BontleContext context)
        {
            _context = context;
        }

        // Create a new professional entry
        public async Task CreateProfessionalAsync(Professional professional)
        {
            await _context.Professionals.AddAsync(professional);
            await _context.SaveChangesAsync();
        }

        // Delete a professional entry
        public async Task DeleteProfessionalAsync(Professional professional)
        {
            _context.Professionals.Remove(professional);
            await _context.SaveChangesAsync();
        }

        // Get a specific professional by Id (with related User data)
        public async Task<Professional> GetProfessionalByIdAsync(int id)
        {
            return await _context.Professionals
                .Include(p => p.User) // Include related 'User' data if needed
                .FirstOrDefaultAsync(p => p.ProfessionalId == id);
        }

        // Get all professionals (optionally including related data like User)
        public async Task<IReadOnlyList<Professional>> GetProfessionalsAsync()
        {
            return await _context.Professionals
                .Include(p => p.User) // Include related 'User' data if needed
                .ToListAsync();
        }

        // Update an existing professional entry
        public async Task UpdateProfessionalAsync(Professional professional)
        {
            // Update the 'Professional' entity
            _context.Entry(professional).State = EntityState.Modified;

            // Ensure related entities are updated correctly (if needed)
            if (professional.User != null)
            {
                _context.Entry(professional.User).State = EntityState.Modified;
            }

            // Save the changes to the database
            await _context.SaveChangesAsync();
        }
    }
}
