using System.Collections.Generic;

namespace SchoolApp.Services
{
    public interface ISchoolAppDatabaseService
    {
        public void AddStudent(SchoolApp.Models.Student student);

        public Models.Student GetStudent(int? studentNumber);

        public void AddInstructor(SchoolApp.Models.Instructor instructor);

        public Models.Instructor GetInstructor(int? studentNumber);

        public void CreateSubject(Models.Subject subject);

        public Models.Subject GetSubjectById(int SubjectId);

        public Models.Subject GetSubjectByName(string SubjectName);

        public List<Models.Subject> GetAllSubjects();
    }
}