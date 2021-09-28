using System.Collections.Generic;

namespace SchoolApp.Models
{
    public class Instructor
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public int SubjectID { get; set; }

        //navigation key
        public ICollection<Subject> Subjects { get; set; }
    }
}