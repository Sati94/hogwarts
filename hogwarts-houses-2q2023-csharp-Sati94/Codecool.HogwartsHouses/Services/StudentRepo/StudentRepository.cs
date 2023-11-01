using Codecool.HogwartsHouses.Data;
using Codecool.HogwartsHouses.Model;

namespace Codecool.HogwartsHouses.Services.StudentRepo
{
    public class StudentRepository : IStudentRepository
    {
        private List<Student> _students { get; set; }
        public IStudentGenerator StudentGenerator { get; set; }
        public StudentRepository(IStudentGenerator studentGenerator)
        {
            StudentGenerator = studentGenerator;
            _students = studentGenerator.Generate(5).ToList();


        }
        public IEnumerable<Student> GetAll()
        {
            return _students;
        }

        public bool AddStudent(string studentName)
        {
            try
            {
                Student student = new Student(studentName, _students.Last().Id + 1, Pet.Owl, House.Gryffindor);
                _students.Add(student);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteStudent(int id)
        {
            try
            {
                return _students.Remove(_students.Single(r => r.Id == id));
            }
            catch
            {
                return false;
            }
        }


    }
}

