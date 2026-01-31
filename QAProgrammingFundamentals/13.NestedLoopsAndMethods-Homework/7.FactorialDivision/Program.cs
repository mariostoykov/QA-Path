
int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());

int firstFactoriel = FindFactorial(firstNumber);
int secondFactoriel = FindFactorial(secondNumber);

Console.WriteLine(firstFactoriel / secondFactoriel);

static int FindFactorial(int num)
{
    int factorial = 1;

    for (int i = num; i >= 1; i--)
    {
        factorial = i * factorial;
    }

    return factorial;
}