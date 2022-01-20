using System.Collections.Generic;

namespace SchoolApp.Models 
{
    public class Subject 
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string ShortName { get; set; }

        public string Description { get; set; }

        public ICollection<Enrollment > Enrollments { get; set; }
    }
}
