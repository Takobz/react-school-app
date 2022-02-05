using SchoolApp.Models.DatabaseModels;
using SchoolApp.Mappers;
using System.Linq;
using System.Collections.Generic;

namespace SchoolApp.Services
{
    public class SchoolAppDatabaseService : ISchoolAppDatabaseService
    {
        private readonly ISchoolAppContext schoolContext;

        public SchoolAppDatabaseService(ISchoolAppContext schoolContext)
        {
            this.schoolContext = schoolContext;
        }

        //********************************************
        //STUDENT QUERIES
        //********************************************
        public void AddStudent(Models.Student student)
        {
            var studentDatabaseModel = student.ToDatabaseModel();

            schoolContext.Students.Add(studentDatabaseModel);
            schoolContext.SaveChangesToDatabase();
        }

        public Models.Student GetStudent(int? studentNumber)
        {
            var studentDatabaseModel = schoolContext.Students.FirstOrDefault(student => student.StudentNumber == studentNumber);
            if(studentDatabaseModel == null)
            {
                return null;
            }
            return studentDatabaseModel.ToStudentModel();
        }

        //********************************************
        //INSTRUCTOR QUERIES
        //********************************************
        public void AddInstructor(Models.Instructor instructor)
        {
            var InstructorDatabaseModel = instructor.ToDatabaseModel();

            schoolContext.Instructors.Add(InstructorDatabaseModel);
            schoolContext.SaveChangesToDatabase();
        }

        public Models.Instructor GetInstructor(int? instructorID)
        {
            var instructorDatabaseModel  = schoolContext.Instructors.FirstOrDefault(instructor => instructor.ID == instructorID);
            if(instructorDatabaseModel == null)
            {
                return null;
            }
            return instructorDatabaseModel.ToInstructorModel();
        }

        public List<Models.Instructor> GetAllInstructors()
        {
            var instructors = schoolContext.Instructors.Select(x => x.ToInstructorModel())
                                .ToList();

            return instructors;
        }

        //********************************************
        //SUBJECT QUERIES
        //********************************************
        public void CreateSubject(Models.Subject subject)
        {
            var subjectDatabaseModel = subject.ToDatabaseModel();

            schoolContext.Subjects.Add(subjectDatabaseModel);
            schoolContext.SaveChangesToDatabase();
        }

        public Models.Subject GetSubjectById(int SubjectId)
        {
            var Subject = schoolContext.Subjects.FirstOrDefault(x => x.ID == SubjectId);

            if(Subject == null)
            {
                return null;
            }
            return Subject.ToSubjectModel();
        }

        public Models.Subject GetSubjectByName(string SubjectName)
        {
            var Subject = schoolContext.Subjects.FirstOrDefault(x => x.Name == SubjectName);

            if(Subject == null)
            {
                return null;
            }
            return Subject.ToSubjectModel();
        }

        public List<Models.Subject> GetAllSubjects()
        {
            return schoolContext.Subjects.Select(x => x.ToSubjectModel()).ToList();
        }

        public void CreatePost(Models.Post model)
        {
            var databaseModel = model.ToDatabaseModel();

            schoolContext.Posts.Add(databaseModel);
            schoolContext.SaveChangesToDatabase();
        }

        //********************************************
        //POSTS QUERIES
        //********************************************
        public Models.Post GetPostById(int postId)
        {
            var post = schoolContext.Posts.FirstOrDefault(x => x.ID == postId);
            return post.ToPostModel();
        }

        public List<Models.Post> GetPostsByInstructor(int instructorId)
        {
            var posts = schoolContext.Posts.Where(x => x.InstructorID == instructorId)
                        .Select(x => x.ToPostModel())
                        .ToList();

            return posts;
        }

        public List<Models.Post> GetPostsForSubject(int subjectId)
        {
            var posts = schoolContext.Posts.Where(x => x.SubjectID == subjectId)
                        .Select(x => x.ToPostModel())
                        .ToList();

            return posts;
        }

        public List<Models.Post> GetAllPosts()
        {
            var posts = schoolContext.Posts.Select(x => x.ToPostModel())
                        .ToList();

            return posts;
        }
    }
}