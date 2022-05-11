using Dating.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dating.Application.Contracts.Persistance
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetPosts();
        public Task<User> GetPost(int id);
    }
}
