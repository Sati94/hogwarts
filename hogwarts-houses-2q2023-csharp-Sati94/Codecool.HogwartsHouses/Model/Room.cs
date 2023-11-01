namespace Codecool.HogwartsHouses.Model;

public class Room
{
    public string Name { get; set; }
    public int Id { get; set; }
    public List<Student> Students { get; set; }
    public Room(string name, int id)
    {
        Name = name;
        Id = id;
        Students = new List<Student>();
    }

    public void AddStudent(Student student)
    {
        Students.Add(student);
    }
}