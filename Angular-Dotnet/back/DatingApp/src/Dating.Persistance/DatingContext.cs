using Dating.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dating.Persistance
{
    public class DatingContext : DbContext
    {
        public DatingContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
