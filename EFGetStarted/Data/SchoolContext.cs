using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using EFGetStarted.Models;

namespace EFGetStarted.Data
{
    class SchoolContext : DbContext
    {

        /*
        public SchoolContext (DbContextOptions<SchoolContext> options)
            : base(options)
        {
        }
        */

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=SchoolContextCA;Trusted_Connection=True;MultipleActiveResultSets=true");

        // DBSets
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}
