
string input = "";
while ((input = Console.ReadLine()) != "End")
{
    int n = int.Parse(input);
    int sum = 0;
    while (n > 0)
    {
        int lastDigit = n % 10;
        sum += lastDigit;
        n /= 10;
    }

    Console.WriteLine($"Sum of digits = {sum}");
}
Console.WriteLine($"Goodbye");


