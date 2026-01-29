decimal packagePensPrice = 5.80m;
decimal packageMarkersPrice = 7.20m;
decimal boardCleanerPrice = 1.20m;

double penPackage = double.Parse(Console.ReadLine());
double markerPackage = double.Parse(Console.ReadLine());
double cleanerPackage = double.Parse(Console.ReadLine());
double discount = double.Parse(Console.ReadLine());

decimal penPackagesCosts = (decimal)penPackage * packagePensPrice;
decimal markerPackagesCosts = (decimal)markerPackage * packageMarkersPrice;
decimal boardCleanerCosts = (decimal)cleanerPackage * boardCleanerPrice;

decimal totalCosts = penPackagesCosts + markerPackagesCosts + boardCleanerCosts;
decimal discountAmount = totalCosts * ((decimal)discount / 100);
decimal totalCostsAfterDiscount = totalCosts - discountAmount;

Console.WriteLine(totalCostsAfterDiscount);



