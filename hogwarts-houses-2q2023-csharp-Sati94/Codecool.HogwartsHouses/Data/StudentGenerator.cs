using Codecool.HogwartsHouses.Model;

namespace Codecool.HogwartsHouses.Data
{
    public class StudentGenerator : IStudentGenerator
    {
        public IEnumerable<Student> Generate(int count)
        {
            for (int i = 0; i < count; i++)
            {
                yield return new Student(
                    $"Student{i}",
                    i,
                    (Pet)Random.Shared.Next(Enum.GetValues(typeof(Pet)).Length),
                    (House)Random.Shared.Next(Enum.GetValues(typeof(House)).Length));
            }
        }
    }
}
