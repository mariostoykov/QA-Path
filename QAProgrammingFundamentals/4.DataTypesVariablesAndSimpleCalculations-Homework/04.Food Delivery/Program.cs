
int countOfChickenMenus = int.Parse(Console.ReadLine());
int countOfFishMenus = int.Parse(Console.ReadLine());
int countOfVegetarianMenus = int.Parse(Console.ReadLine());

double chickenMenuPrice = 10.35;
double fishMenuPrice = 12.40;
double vegetarianMenuPrice = 8.15;
double deliveryPrice = 2.50;

double priceAllChickenMenus = countOfChickenMenus * chickenMenuPrice;
double priceAllFishMenus = countOfFishMenus * fishMenuPrice;
double priceAllVegetarianMenus = countOfVegetarianMenus * vegetarianMenuPrice;

double totalBill = priceAllChickenMenus + priceAllFishMenus + priceAllVegetarianMenus;
double dessertPrice = totalBill * 0.2;
double orderPrice = totalBill + dessertPrice + deliveryPrice;

Console.WriteLine(orderPrice);


