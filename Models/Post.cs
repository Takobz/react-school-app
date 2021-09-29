namespace SchoolApp.Models
{
    public class Post
    {
        public int ID { get; set; }

        public string Text { get; set; }

        public string Heading { get; set; }

        public int SubjectID { get; set; }

        public int InstructorID { get; set; }

        public Subject Subject { get; set; }
        public Instructor Instructor { get; set;}
    }
}