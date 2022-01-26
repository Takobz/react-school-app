using System.Collections.Generic;

namespace SchoolApp.Models.DatabaseModels
{
    public class Instructor
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public int? SubjectId { get; set; }

        //navigation key
        public ICollection<Subject> Subjects { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}