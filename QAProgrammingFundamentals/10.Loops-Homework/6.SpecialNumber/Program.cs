
int num = int.Parse(Console.ReadLine());

int numCopy = num;
bool isSpecial = true;

while (numCopy > 0)
{
    int lastDigit = numCopy % 10;

    if (num % lastDigit == 0)
    {
        isSpecial = true;
    }
    else
    {
        isSpecial = false;
        break;
    }

    numCopy = numCopy / 10;
}

if (isSpecial)
{
    Console.WriteLine($"{num} is special");
}
else
{
    Console.WriteLine($"{num} is not special");
}