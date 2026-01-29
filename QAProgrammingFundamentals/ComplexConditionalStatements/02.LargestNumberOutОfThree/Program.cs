int first = int.Parse(Console.ReadLine());
int second = int.Parse(Console.ReadLine());
int third = int.Parse(Console.ReadLine());

if (first > second)
{
 if (first > third)
    {
        Console.WriteLine(first);
    }
    else
    {
        Console.WriteLine(third);
    } 

}
else
{
    if (second > third)
    {
        Console.WriteLine(second);
    }
    else
    { 
        Console.WriteLine(third);
    }
}