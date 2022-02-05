using System.Collections.Generic;

namespace SchoolApp.Services
{
    public interface ISchoolAppDatabaseService
    {
        //********************************************
        //STUDENT QUERIES
        //********************************************
        public void AddStudent(SchoolApp.Models.Student student);

        public Models.Student GetStudent(int? studentNumber);

        //********************************************
        //INSTRUCTOR QUERIES
        //********************************************
        public void AddInstructor(SchoolApp.Models.Instructor instructor);

        public Models.Instructor GetInstructor(int? studentNumber);

        public List<Models.Instructor> GetAllInstructors();

        //********************************************
        //SUBJECT QUERIES
        //********************************************
        public void CreateSubject(Models.Subject subject);

        public Models.Subject GetSubjectById(int SubjectId);

        public Models.Subject GetSubjectByName(string SubjectName);

        public List<Models.Subject> GetAllSubjects();

        //********************************************
        //POSTS QUERIES
        //********************************************
        public void CreatePost(SchoolApp.Models.Post post);
        
        public Models.Post GetPostById(int postId);

        public List<Models.Post> GetPostsByInstructor(int instructorId);

        public List<Models.Post> GetPostsForSubject(int subjectId);

        public List<Models.Post> GetAllPosts();
    }
}