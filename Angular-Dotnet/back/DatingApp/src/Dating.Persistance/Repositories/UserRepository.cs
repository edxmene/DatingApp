using Dating.Application.Contracts.Persistance;
using Dating.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dating.Persistance.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DatingContext _context;

        public UserRepository(DatingContext context)
        {
            _context = context;
        }

        public Task<User> GetPost(int id)
        {
            return _context.Users.FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<IEnumerable<User>> GetPosts()
        {
            return await _context.Users.ToListAsync();
        }
    }
}
