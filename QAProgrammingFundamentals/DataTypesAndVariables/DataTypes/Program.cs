 
int days = int.Parse(Console.ReadLine());
int hours = days * 24;
int minutes = hours * 60;

Console.WriteLine($"Minutes = {minutes}");



double radiusOfCircle  = double.Parse(Console.ReadLine());

double area = radiusOfCircle * radiusOfCircle * Math.PI;
double perimeter = 2* radiusOfCircle * Math.PI;

Console.WriteLine($"Area = {area:F2}");
Console.WriteLine($"Perimeter = {perimeter:F2}");
