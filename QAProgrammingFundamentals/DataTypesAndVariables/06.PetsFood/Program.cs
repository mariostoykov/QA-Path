
int dogFoodPac = int.Parse(Console.ReadLine());
int catFoodPac = int.Parse(Console.ReadLine());

decimal dogFoodCosts = dogFoodPac * 2.50m;
decimal catFoodCosts = catFoodPac * 4.00m;
decimal totalExpenses = dogFoodCosts + catFoodCosts;

Console.WriteLine($"{totalExpenses:F2} lv.");

