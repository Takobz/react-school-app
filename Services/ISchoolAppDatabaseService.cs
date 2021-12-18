namespace SchoolApp.Services
{
    public interface ISchoolAppDatabaseService
    {
        public void AddStudent(SchoolApp.Models.Student student);

        public Models.Student GetStudent(int? studentNumber);

        public void AddInstructor(SchoolApp.Models.Instructor instructor);

        public Models.Instructor GetInstructor(int? studentNumber);
    }
}