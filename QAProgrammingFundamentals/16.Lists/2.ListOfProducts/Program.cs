
int n = int.Parse(Console.ReadLine());

List<string> products = new List<string>();

for (int i = 0; i < n; i++)
{
    string currentProduct = Console.ReadLine();
    products.Add(currentProduct);
}

products.Sort();

int counter = 1;

foreach (string product in products)
{
    Console.WriteLine($"{counter}.{product}");
    counter++;
}