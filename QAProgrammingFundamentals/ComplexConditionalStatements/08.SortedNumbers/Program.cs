int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

if (a < b && b < c)
{
    Console.WriteLine("Ascending");
}
else if (a > b && b > c)
{
    Console.WriteLine("Descending");
}
else
{
    Console.WriteLine("Not sorted");
}