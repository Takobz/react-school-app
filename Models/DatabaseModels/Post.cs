using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolApp.Models.DatabaseModels
{
    public class Post
    {
        public int ID { get; set; }

        public string Info { get; set; }

        public string Heading { get; set; }

        [Column("SUB_ID")]
        public int SubjectID { get; set; }
        public Subject Subject { get; set; }

        [Column("INSTRUCTOR_ID")]
        public int InstructorID { get; set; }
        public Instructor Instructor { get; set; }
    }
}
