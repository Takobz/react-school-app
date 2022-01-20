using Microsoft.EntityFrameworkCore;

namespace SchoolApp.Models.DatabaseModels 
{
    public interface ISchoolAppContext
    {
        public DbSet<Student> Students {get; set;}

        public DbSet<Subject> Subjects {get; set;}

        public DbSet<Instructor> Instructors {get; set;}

        public DbSet<Post> Posts {get; set;}

        public DbSet<Enrollment> Enrollments {get; set;}

        public void SaveChangesToDatabase();
    } 
}