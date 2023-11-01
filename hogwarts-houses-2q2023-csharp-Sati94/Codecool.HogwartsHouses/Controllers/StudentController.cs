using Codecool.HogwartsHouses.Model;
using Codecool.HogwartsHouses.Services.StudentRepo;
using Microsoft.AspNetCore.Mvc;

namespace Codecool.HogwartsHouses.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class StudentController : Controller
    {
        public IStudentRepository StudentRepository { get; set; }

        public StudentController(IStudentRepository studentRepository)
        {
            StudentRepository = studentRepository;

        }

        [HttpGet]
        [Route("/students")]
        public IEnumerable<Student> GetAllActionResult()
        {
            return StudentRepository.GetAll();
        }

        [HttpPost]
        [Route("/students")]
        public IActionResult AddStudent(string studentName)
        {
            try
            {
                return Ok(StudentRepository.AddStudent(studentName));

            }
            catch
            {
                return null;
            }
        }

        [HttpDelete]
        [Route("/students/{studentId:int}")]
        public IActionResult DeleteStudent(int id)
        {
            try
            {
                return Ok(StudentRepository.DeleteStudent(id));
            }
            catch
            {
                return null;
            }
        }
    }
}
