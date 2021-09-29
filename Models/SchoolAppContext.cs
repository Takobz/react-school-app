using Microsoft.EntityFrameworkCore;

namespace SchoolApp.Models
{
    public class SchoolAppContext : DbContext, ISchoolAppContext
    {
        public DbSet<Student> Students;

        public DbSet<Subject> Subjects;

        public DbSet<Instructor> Instructors;

        public DbSet<Post> Posts;

        public DbSet<Enrollment> Enrollments;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = System.IO.Path.Combine(
                System.Environment.CurrentDirectory, @"database\SchoolApp.db"
            );
            optionsBuilder.UseSqlite($"Filename={path}");
        }
    }
}