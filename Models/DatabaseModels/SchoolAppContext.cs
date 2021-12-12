using Microsoft.EntityFrameworkCore;

namespace SchoolApp.Models.DatabaseModels
{
    public class SchoolAppContext : DbContext, ISchoolAppContext
    {
        public DbSet<Student> Students {get; set;}

        public DbSet<Subject> Subjects {get; set;}

        public DbSet<Instructor> Instructors {get; set;}

        public DbSet<Post> Posts {get; set;}

        public DbSet<Enrollment> Enrollments {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = System.IO.Path.Combine(
                System.Environment.CurrentDirectory, @"database\SchoolApp.db"
            );
            optionsBuilder.UseSqlite($"Filename={path}");
        }

        public void SaveChangesToDatabase()
        {
            SaveChanges();
        }
    }
}