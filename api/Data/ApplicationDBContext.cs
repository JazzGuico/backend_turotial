using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace api.Data
{
    public class ApplicationDBContext : IdentityDbContext<AppUser>
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions) 
        : base(dbContextOptions)
        {
       
        }

        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            List<IdentityRole> roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Id = "8f2c1a4e-5b7d-4c3a-9e10-1a2b3c4d5e6f",
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                    ConcurrencyStamp = "8f2c1a4e-5b7d-4c3a-9e10-1a2b3c4d5e6f"
                },
                new IdentityRole
                {
                    Id = "3d9e7b21-6a4f-4f8c-b5d2-7c8e9f0a1b2c",
                    Name = "User",
                    NormalizedName = "USER",
                    ConcurrencyStamp = "3d9e7b21-6a4f-4f8c-b5d2-7c8e9f0a1b2c"
                },
            };
            builder.Entity<IdentityRole>().HasData(roles);
        }
    }
}