using System.Linq;

namespace SchoolApp.Mappers
{
    public static class SubjectMapper
    {
        public static Models.DatabaseModels.Subject ToDatabaseModel(this Models.Subject subjectModel)
        {
            return new Models.DatabaseModels.Subject
            {
                ID = subjectModel.ID,
                Name  = subjectModel.Name,
                ShortName = subjectModel.ShortName,
                DESCRIPTION = subjectModel.Description
            };
        }

        public static Models.Subject ToSubjectModel(this Models.DatabaseModels.Subject databaseModel)
        {
            return new Models.Subject
            {
                ID = databaseModel.ID,
                Name = databaseModel.Name,
                ShortName = databaseModel.ShortName,
                Description = databaseModel.DESCRIPTION,
            };
        }

        
    }
}