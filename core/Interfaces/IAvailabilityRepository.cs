using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Models.Entity;

namespace core.Interfaces
{
    public interface IAvailabilityRepository
    {
        Task<Availability> GetAvailabityByIdAsync(int Id);
        Task<IReadOnlyList<Availability>> GetAvailabilitiesAsync();
    }
}