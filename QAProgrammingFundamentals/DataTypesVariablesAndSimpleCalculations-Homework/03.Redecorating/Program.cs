
int nylonAmount = int.Parse(Console.ReadLine());
int paintAmount = int.Parse(Console.ReadLine());
int thinnerAmount = int.Parse(Console.ReadLine());
int hoursOfWorking = int.Parse(Console.ReadLine());

double nylonPrice = 1.50;
double paintPrice = 14.50;
double thinnerPrice = 5.00;
double bagsPrice = 0.40;

double priceForAllNylon = (nylonAmount + 2) * nylonPrice;
double priceForAllPaint = paintAmount * 1.1 * paintPrice;
double priceForAllThinner = thinnerAmount * thinnerPrice;

double materialsPrice = priceForAllNylon + priceForAllPaint + priceForAllThinner + bagsPrice;

double priceForWorkers = materialsPrice * 0.3 * hoursOfWorking;


double finalPrice = materialsPrice + priceForWorkers;

Console.WriteLine(finalPrice);

