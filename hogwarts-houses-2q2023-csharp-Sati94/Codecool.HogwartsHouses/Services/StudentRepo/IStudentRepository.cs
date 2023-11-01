using Codecool.HogwartsHouses.Model;

namespace Codecool.HogwartsHouses.Services.StudentRepo
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAll();
        bool AddStudent(string studentName);
        bool DeleteStudent(int id);
    }
}
