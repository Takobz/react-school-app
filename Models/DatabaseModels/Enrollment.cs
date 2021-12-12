namespace SchoolApp.Models.DatabaseModels
{
    public class Enrollment
    {
        public int ID { get; set; }

        public Student StudentID { get; set; }
        
        public Student Student { get; set; }
        public Subject Subject { get; set; }
    }
}