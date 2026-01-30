
int stopNumber = int.Parse(Console.ReadLine());

int lastNum = 0;

while (true)
{
    int currentNum = int.Parse(Console.ReadLine());

    if (currentNum == stopNumber)
    {
        double output = lastNum * 1.2;

        Console.WriteLine(output);
        break;
    }

    lastNum = currentNum;
}