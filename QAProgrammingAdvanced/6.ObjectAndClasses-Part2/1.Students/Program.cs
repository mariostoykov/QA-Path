
public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Grade { get; set; }

    public Student(string firstName, string lastName, double grade)
    {
        FirstName = firstName;
        LastName = lastName;
        Grade = grade;
    }
}

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Student> students = new List<Student>();

        for (int i = 0; i < n; i++)
        {
            string[] parts = Console.ReadLine().Split(' ');
            string firstName = parts[0];
            string lastName = parts[1];
            double grade = double.Parse(parts[2]);

            students.Add(new Student(firstName, lastName, grade));
        }

        var sortedStudents = students.OrderByDescending(student => student.Grade);

        foreach (Student student in sortedStudents)
        {
            Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:F2}");
        }
    }
}