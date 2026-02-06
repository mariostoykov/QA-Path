
public class Program
{
    public static void Main()
    {
        const int totalNumbers = 10;
        int start = 1;
        int end = 100;
        List<int> numbers = new List<int>();

        while (numbers.Count < totalNumbers)
        {
            try
            {
                int number = ReadNumber(start, end);
                numbers.Add(number);
                start = number;
            }

            catch (FormatException)
            {
                Console.WriteLine("Invalid Number!");
            }

            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        Console.WriteLine(string.Join(", ", numbers));
    }

    public static int ReadNumber(int start, int end)
    {
        string input = Console.ReadLine();

        if (!int.TryParse(input, out int number))
        {
            throw new FormatException();
        }

        if (number <= start ||  number >= end)
        {
            throw new ArgumentOutOfRangeException(
                $"Your number is not in range {start} - {end}!");
        }

        return number;
    }
}