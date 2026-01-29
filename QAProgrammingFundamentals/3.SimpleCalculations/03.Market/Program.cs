double tomatoPrice = double.Parse(Console.ReadLine());
double tomatoes = double.Parse(Console.ReadLine());

double cucumberPrice = double.Parse(Console.ReadLine());
double cucumbers = double.Parse(Console.ReadLine());

double tomatoCosts = tomatoes * tomatoPrice;
double cucumberCosts = cucumbers * cucumberPrice;

double totalCosts = tomatoCosts + cucumberCosts;

Console.WriteLine($"{totalCosts:F2}");



