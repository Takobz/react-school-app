using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolApp.Models
{
    public class Student
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }
        
        [Column("STD_NUMBER")]
        public int StudentNumber { get; set; }
    }
}