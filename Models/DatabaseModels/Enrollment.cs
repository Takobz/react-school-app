namespace SchoolApp.Models.DatabaseModels
{
    public class Enrollment
    {
        public int Id { get; set; }
        
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
    }
}