double bathW = double.Parse(Console.ReadLine());
double bathH = double.Parse(Console.ReadLine());
double tileW = double.Parse(Console.ReadLine());
double tileH = double.Parse(Console.ReadLine());

double bathArea = bathH * bathW * 1.10;
double tileArea = tileH * tileW;

double tilesNeeded = bathArea / tileArea;

Console.WriteLine($"{tilesNeeded:F0}");

