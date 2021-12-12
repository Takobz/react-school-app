using SchoolApp.Models.DatabaseModels;
using SchoolApp.Mappers;

namespace SchoolApp.Services
{
    public class SchoolAppDatabaseService : ISchoolAppDatabaseService
    {
        private readonly ISchoolAppContext schoolContext;

        public SchoolAppDatabaseService(ISchoolAppContext schoolContext)
        {
            this.schoolContext = schoolContext;
        }

        //queries.
        public void AddStudent(Models.Student student)
        {
            var studentDatabaseModel = student.ToDatabaseModel();

            schoolContext.Students.Add(studentDatabaseModel);
            schoolContext.SaveChangesToDatabase();
        }
    }
}