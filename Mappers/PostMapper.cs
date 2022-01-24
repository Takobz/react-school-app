namespace SchoolApp.Mappers
{
    public static class PostMapper
    {
        public static SchoolApp.Models.DatabaseModels.Post ToDatabaseModel(this SchoolApp.Models.Post model)
        {
            return new SchoolApp.Models.DatabaseModels.Post
            {
                Info = model.Info,
                Heading = model.Heading,
                SubjectID = model.SubjectID,
                InstructorID = model.InstructorID
            };
        }

        public static SchoolApp.Models.Post ToPostModel(this SchoolApp.Models.DatabaseModels.Post databaseModel)
        {
            return new SchoolApp.Models.Post
            {
                Info = databaseModel.Info,
                Heading = databaseModel.Heading,
                SubjectID = databaseModel.SubjectID,
                InstructorID = databaseModel.InstructorID
            };
        }
    }
}