using SchoolApp.Models;

namespace SchoolApp.Services
{
    public class SchoolAppDatabaseService : ISchoolAppDatabaseService
    {
        private readonly ISchoolAppContext schoolContext;

        public SchoolAppDatabaseService(ISchoolAppContext schoolContext)
        {
            this.schoolContext = schoolContext;
        }

        //queries.
    }
}