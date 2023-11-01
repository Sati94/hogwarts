namespace Codecool.HogwartsHouses.Model;

public class Student
{
    public string Name { get; set; }
    public int Id { get; set; }
    public Pet Pet { get; set; }
    public House House { get; set; }

    public Student(string name, int id, Pet pet, House house)
    {
        Name = name;
        Id = id;
        Pet = pet;
        House = house;
    }
}