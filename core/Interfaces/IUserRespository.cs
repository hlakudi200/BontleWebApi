using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Models.Entity;

namespace core.Interfaces
{
    public interface IUserRespository
    {
        Task<User> GetUserByIdAsync(int id);
        Task<IReadOnlyList<User>> GeUsersAsync();
        Task AddUserAsync(User user);
        Task UpdateUserAsync(User user);
        Task DeleteUserAsync(User user);
    }
}