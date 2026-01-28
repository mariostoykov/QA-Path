using System.ComponentModel.Design;
using System.Net.Sockets;

string ticketType = Console.ReadLine();

if (ticketType == "regular")
{
    decimal price = 1.60m;
    Console.WriteLine($"${price:F2}");
}
else if (ticketType == "student")
{
    decimal price = 1.00m;
    Console.WriteLine($"${price:F2}");
}
else
{
    Console.WriteLine("Invalid ticket type!");
}