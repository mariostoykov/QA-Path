string movieType = Console.ReadLine();
int rows = int.Parse(Console.ReadLine());
int seatsPerRow = int.Parse(Console.ReadLine());

if (movieType == "Premiere")
{
    int totalSeats = rows * seatsPerRow;
    double totalPrice = totalSeats * 12.00;
    Console.WriteLine($"{totalPrice:F2}");
}
else if (movieType == "Normal")
{
    int totalSeats = rows * seatsPerRow;
    double totalPrice = totalSeats * 7.50;
    Console.WriteLine($"{totalPrice:F2}");
}
else
{
    int totalSeats = rows * seatsPerRow;
    double totalPrice = totalSeats * 5.00;
    Console.WriteLine($"{totalPrice:F2}");
}
