using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UserManagement.Models;

namespace UserManagement.Data
{
    public class UserManagementContext : DbContext
    {
        public UserManagementContext (DbContextOptions<UserManagementContext> options)
            : base(options)
        {
        }

        public DbSet<UserManagement.Models.User> User { get; set; } = default!;
    }
}
