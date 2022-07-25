using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using UserManagement.Data;
using System;
using System.Linq;
using UserManagement.Models;

namespace UserManagement.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new UserManagementContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<UserManagementContext>>());
            // Look for any Management.
            if (context.User.Any())
            {
                return;   // DB has been seeded
            }

            context.User.AddRange(

                new User
                {
                    FirstName = "mohamed",
                    LastName = "Ahmed ",
                    BrithDate = new DateTime(2000, 4, 1),
                    EmailAddress = "mohamed.cs@gmail.com"
                },

                new User
                {
                    FirstName = "Amr",
                    LastName = "Anwar ",
                    BrithDate = new DateTime(2001, 3, 9),
                    EmailAddress = "Amranwar123@gmail.com"
                },

                new User
                {
                    FirstName = "Khaled",
                    LastName = "Waleed",
                    BrithDate = new DateTime(1999, 4, 22),
                    EmailAddress = "Khaled.cs@gmail.com"
                },

                new User
                {
                    FirstName = "Eid",
                    LastName = "Ahmed ",
                    BrithDate = new DateTime(1998, 11, 22),
                    EmailAddress = "Eid.cs@gmail.com"
                },
                new User
                {
                    FirstName = "Rana",
                    LastName = "hwary",
                    BrithDate = new DateTime(2001, 4, 2),
                    EmailAddress = "Ranahwary.cs@gmail.com"
                }
            );
            context.SaveChanges();
        }
    }
}

