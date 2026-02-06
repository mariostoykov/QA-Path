
int n = int.Parse(Console.ReadLine());

Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

for (int i = 0; i < n; i++)
{
    string name = Console.ReadLine();
    double grade = double.Parse(Console.ReadLine());
    
    if (!students.ContainsKey(name))
    {
        students[name] = new List<double>();
    }

    students[name].Add(grade);
}

foreach (var student in students)
{
    double average = student.Value.Average();

    if (average >= 4.50)
    {
        Console.WriteLine($"{student.Key} -> {average:F2}");
    }
}