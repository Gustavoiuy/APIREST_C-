using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRental.Api.Data;
using CarRental.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Api
{
    public static class SeedData
    {
        public static void Initialize(this IApplicationBuilder app)
        {

            using var scope = app.ApplicationServices.CreateScope();
            //using var context = new AppDbContext(serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>());
            using var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            if (context.Users.Any())
                return; // Ya hay usuarios, no hace falta seed

            var users = new List<User>
            {
                new User { Username = "alice", Email = "alice@example.com" },
                new User { Username = "bob", Email = "bob@example.com" }
            };

            context.Users.AddRange(users);
            context.SaveChanges();
        }
    }
}