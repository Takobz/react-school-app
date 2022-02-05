
namespace SchoolApp.Mappers
{
    public static class InstructorMapper
    {
        public static Models.DatabaseModels.Instructor ToDatabaseModel(this Models.Instructor instructor)
        {
            return new Models.DatabaseModels.Instructor
            {
                ID = instructor.ID,
                Name = instructor.Name,
                Surname = instructor.Surname,
            };
        }

        public static Models.Instructor ToInstructorModel(this Models.DatabaseModels.Instructor databaseModel)
        {
            return new Models.Instructor
            {
                ID = databaseModel.ID,
                Name = databaseModel.Name,
                Surname = databaseModel.Surname,
            };
        }
    }
}
