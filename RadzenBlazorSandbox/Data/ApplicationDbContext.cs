using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace RadzenBlazorSandbox.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<EmailTemplate> EmailTemplates { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Roster> Rosters { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Seed data
            builder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "Admin", NormalizedName = "ADMIN", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });
            builder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "Educator", NormalizedName = "EDUCATOR", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });

            builder.Entity<Class>().HasData(new Class { Name = "First Class",Id = 1});
            builder.Entity<Student>().HasData(new Student { Name = "Adam", Id = 1 });
            builder.Entity<Student>().HasData(new Student { Name = "Eve", Id = 2 });
            builder.Entity<Roster>().HasData(new Roster { Id = 1,StudentId = 1, ClassId = 1});
            builder.Entity<Roster>().HasData(new Roster { Id = 2, StudentId = 2, ClassId = 1 });




        }
    }
}
