
int lenghtCm = int.Parse(Console.ReadLine());
int widthCm = int.Parse(Console.ReadLine());
int heightCm = int.Parse(Console.ReadLine());
double occupiedPercentage = double.Parse(Console.ReadLine());

double volumeOfAquariumCm3 = lenghtCm * widthCm * heightCm;
double volumeOfAquariumLiters = volumeOfAquariumCm3 / 1000;
double requiredLiters = volumeOfAquariumLiters * (1 - occupiedPercentage / 100);

Console.WriteLine($"{requiredLiters:F2}");


