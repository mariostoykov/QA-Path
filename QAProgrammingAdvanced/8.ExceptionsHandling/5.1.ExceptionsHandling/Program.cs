
public class Program
{
    public static void Main()
    {
        try
        {
            int number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("Invalid number.");
            }
            else
            {
                double result = Math.Sqrt(number);
                Console.WriteLine(result);
            }
        }

        catch (FormatException)
        {
            Console.WriteLine("Invalid input.");
        }
        finally
        {
            Console.WriteLine("Goodbye.");
        }
    }
}