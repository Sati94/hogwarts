using Codecool.HogwartsHouses.Data;
using Codecool.HogwartsHouses.Model;
using Codecool.HogwartsHouses.Services.RoomRepo;
using Codecool.HogwartsHouses.Services.StudentRepo;
using Microsoft.AspNetCore.Mvc;
using Npgsql;

namespace Codecool.HogwartsHouses.Controllers;

[ApiController]
[Route("[controller]")]
public class RoomController : Controller
{
    public IRoomRepository RoomRepository { get; set; }
    public IStudentRepository StudentRepository { get; set; }

    public RoomController(IRoomRepository roomRepository, IStudentRepository studentRepository)
    {
        RoomRepository = roomRepository;
        StudentRepository = studentRepository;
    }

    [HttpGet]
    public IEnumerable<Room> GetAllActionResult()
    {
        return RoomRepository.GetAll();
    }

    [HttpPost]
    public IActionResult AddRoom(string roomName)
    {
        try
        {
            return Ok(RoomRepository.AddRoom(roomName));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet]
    [Route("{roomID:int}")]
    public IActionResult GetRoomById(int id)
    {
        try
        {
            return Ok(RoomRepository.GetRoomById(id));
        }
        catch
        {
            return null;
        }
    }

    [HttpDelete]
    [Route("{roomID:int}")]
    public IActionResult DeleteRoom(int id)
    {
        try
        {
            return Ok(RoomRepository.DeleteRoom(id));
        }
        catch
        {
            return null;
        }
    }

    [HttpPost]
    [Route("{roomId}/students/{studentId}")]
    public IActionResult AddStudentToRoom(int roomId, int studentId)
    {
        try
        {
            IEnumerable<Student> Students = StudentRepository.GetAll();
            var student = Students.First(s => s.Id == studentId);

            return Ok(RoomRepository.AssignedStudent(student, roomId));
        }
        catch
        {
            return NotFound();
        }
    }


}