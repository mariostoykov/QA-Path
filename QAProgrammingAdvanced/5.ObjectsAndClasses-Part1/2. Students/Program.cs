
public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string HomeTown { get; set; }

    public Student(string firstName, string lastName, int age, string homeTown)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        HomeTown = homeTown;
    }
}

public class Program
{
    public static void Main()
    {
        List<Student> students = new List<Student>();

        while (true)
        {
            string input = Console.ReadLine();

            if (input == "end")
            {
                break;
            }

            string[] parts = input.Split(' ');
            string firstName = parts[0];
            string lastName = parts[1];
            int age = int.Parse(parts[2]);
            string homeTown = parts[3];

            students.Add(new Student(firstName, lastName, age, homeTown));
        }

        string cityFilter = Console.ReadLine();

        foreach (var student in students)
        {
            if (student.HomeTown == cityFilter)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }
}
