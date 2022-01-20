namespace SchoolApp.Mappers
{
    public static class PostMapper
    {
        public static SchoolApp.Models.DatabaseModels.Post ToDatabaseModel(this SchoolApp.Models.Post model)
        {
            return new SchoolApp.Models.DatabaseModels.Post
            {
                Text = model.Text,
                Heading = model.Heading,
                Subject = model.Subject.ToDatabaseModel()
            };
        }

        public static SchoolApp.Models.Post ToPostModel(this SchoolApp.Models.DatabaseModels.Post databaseModel)
        {
            return new SchoolApp.Models.Post
            {
                Text = databaseModel.Text,
                Heading = databaseModel.Heading,
                Subject = databaseModel.Subject.ToSubjectModel()
            };
        }
    }
}