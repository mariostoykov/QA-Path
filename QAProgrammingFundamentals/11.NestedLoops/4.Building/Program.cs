
int floors = int.Parse(Console.ReadLine());
int rooms = int.Parse(Console.ReadLine());

for (int f = floors;  f >= 1; f--)
{
    for (int r = 0;  r < rooms; r++)
    {
        if(f == floors)
        {
            Console.WriteLine($"L{f}{r}");
        }
        else if (f % 2 == 1)
        {
            Console.WriteLine($"O{f}{r}");
        }
        else
        {
            Console.WriteLine($"A{f}{r}");
        }
        Console.WriteLine();
    }

}