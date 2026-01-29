string season = Console.ReadLine();
string accomodationType = Console.ReadLine();
int days = int.Parse(Console.ReadLine());

int pricePerDay = 0;
double discount = 0;

if (season == "Spring")
{if (accomodationType == "Hotel")
    {
        pricePerDay = 30;
    }
    else if (accomodationType == "Camping")
    {
        pricePerDay = 10;
    }
    discount = 20;
}

else if (season == "Summer")
{
    if (accomodationType == "Hotel")
    {
        pricePerDay = 50;
    }
    else if (accomodationType == "Camping")
    {
        pricePerDay = 30;
    }
    discount = 0;

}

else if (season == "Autumn")
{
    if (accomodationType == "Hotel")
    {
        pricePerDay = 20;
    }
    else if (accomodationType == "Camping")
    {
        pricePerDay = 15;
    }
    discount = 30;

}

else if (season == "Winter")
{
    if (accomodationType == "Hotel")
    {
        pricePerDay = 40;
    }
    else if (accomodationType == "Camping")
    {
        pricePerDay = 10;
    }
    discount = 10;

}

double finalPriceNoDiscount = days * pricePerDay;
double finalPrice = finalPriceNoDiscount - (finalPriceNoDiscount * discount / 100.0);

Console.WriteLine($"{finalPrice:F2}");
    