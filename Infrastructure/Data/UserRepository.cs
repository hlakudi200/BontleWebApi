using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Interfaces;
using core.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class UserRepository : IUserRespository
    {
        //public BontleContext _context{get;}

        private readonly BontleContext _context;
        private readonly DbSet<User> _dbusers;

        public UserRepository(BontleContext context)
        {
            _context=context;
            _dbusers=_context.Set<User>();
        }

        public async Task AddUserAsync(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteUserAsync(User user)
        {
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }

        public async Task<User> GetUserByIdAsync(int id)
        {       
            return await _context.Users.FindAsync(id);
        }

        public async Task<IReadOnlyList<User>> GeUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task UpdateUserAsync(User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }
    }
}