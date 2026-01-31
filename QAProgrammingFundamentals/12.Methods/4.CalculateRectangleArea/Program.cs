
int width = int.Parse(Console.ReadLine());
int lenght = int.Parse(Console.ReadLine());
int area = CalculateArea(width, lenght);
Console.WriteLine(area);

static int CalculateArea(int w, int l)
{
    int result = w * l;
    return result;
}