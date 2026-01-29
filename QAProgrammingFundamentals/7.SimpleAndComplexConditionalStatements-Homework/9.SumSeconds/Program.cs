int timeOfFirstAtl = int.Parse(Console.ReadLine());
int timeOfSecondAtl = int.Parse(Console.ReadLine());
int timeOfThirdAtl = int.Parse(Console.ReadLine());

int sumTimeInSeconds = timeOfFirstAtl + timeOfSecondAtl + timeOfThirdAtl;

int minutes = sumTimeInSeconds / 60;
int seconds = sumTimeInSeconds % 60;

if (seconds < 10)
{
    Console.WriteLine($"{minutes}:0{seconds}");
}
else
{
    Console.WriteLine($"{minutes}:{seconds}");
}
