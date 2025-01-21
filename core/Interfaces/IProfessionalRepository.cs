using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Models.Entity;

namespace core.Interfaces
{
    public interface IProfessionalRepository
    {
        Task<Professional> GetProfessionalByIdAsync(int Id);
        Task<IReadOnlyList<Professional>> GetProfessionalsAsync();

        Task UpdateProfessionalAsync(Professional professional);
        Task CreateProfessionalAsync(Professional professional);
        Task  DeleteProfessionalAsync(Professional professional);
    }
}