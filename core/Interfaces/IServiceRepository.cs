using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Models.Entity;

namespace core.Interfaces
{
    public interface IServiceRepository
    {

        public Task<Service> GetServiceByIdAsync(int Id);
        public Task<IReadOnlyList<Service>> GetServicesAsync();
        public Task AddServiceAsync(Service service);
        public Task UpdateUserAsync(Service service);
        public Task DeleteServiceAsync(Service service);
    }
}