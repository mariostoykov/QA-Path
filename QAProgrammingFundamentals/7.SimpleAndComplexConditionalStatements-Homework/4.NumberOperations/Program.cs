double num1 = double.Parse(Console.ReadLine());
double num2 = double.Parse(Console.ReadLine());
char mathOperator = char.Parse(Console.ReadLine());

double result = 0;
if (mathOperator == '+')
{
    result = num1 + num2;
}
else if (mathOperator == '-')
{
    result = num1 - num2;
}
else if (mathOperator == '*')
{
    result = num1 * num2;
}
else if (mathOperator == '/')
{
    result = num1 / num2;
}
Console.WriteLine($"{num1} {mathOperator} {num2} = {result:F2}");