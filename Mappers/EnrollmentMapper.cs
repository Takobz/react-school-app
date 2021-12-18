namespace SchoolApp.Mappers 
{
    public static class EnrollmentMapper 
    {
        public static Models.DatabaseModels.Enrollment ToDatabaseModel(this Models.Enrollment enrollmentModel)
        {
            return new Models.DatabaseModels.Enrollment
            {
                Id = enrollmentModel.Id,
                StudentId = enrollmentModel.StudentId,
                SubjectId = enrollmentModel.SubjectId,
            };
        }

        public static Models.Enrollment ToEnrollmentModel(this Models.DatabaseModels.Enrollment databaseModel)
        {
            return new Models.Enrollment
            {
                Id = databaseModel.Id,
                StudentId = databaseModel.StudentId,
                SubjectId = databaseModel.SubjectId,
            };
        }
    }
}