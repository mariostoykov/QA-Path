double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());

double additionResult = a + b;
double subtractionResult = a - b;
double multiplicationResult = a * b;
double divisionResult = a / b;

Console.WriteLine($"{a:F2} + {b:F2} = {additionResult:F2}");
Console.WriteLine($"{a:F2} - {b:F2} = {subtractionResult:F2}");
Console.WriteLine($"{a:F2} * {b:F2} = {multiplicationResult:F2}");
Console.WriteLine($"{a:F2} / {b:F2} = {divisionResult:F2}");
