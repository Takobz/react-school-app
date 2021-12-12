

namespace SchoolApp.Mappers
{
    public static class StudentMapper
    {
        public static SchoolApp.Models.DatabaseModels.Student ToDatabaseModel(this SchoolApp.Models.Student model)
        {
            return new SchoolApp.Models.DatabaseModels.Student
            {
                Name = model.Name,
                Surname = model.Surname,
                StudentNumber = model.StudentNumber,
            };
        }

        public static SchoolApp.Models.Student ToStudentModel(this SchoolApp.Models.DatabaseModels.Student databaseModel)
        {
            return new SchoolApp.Models.Student
            {
                Name = databaseModel.Name,
                Surname = databaseModel.Surname,
                StudentNumber = databaseModel.StudentNumber,
            };
        }
    }
}