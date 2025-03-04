//Input
string month = Console.ReadLine();
int nights = int.Parse(Console.ReadLine());

//Calculations
double studioPrice = 0;
double apartmentPrice = 0;

switch (month)
{
    case ("May"):
    case ("October"):
        studioPrice = 50;
        apartmentPrice = 65;  break;
    case ("June"): 
    case ("September"):
        studioPrice = 75.2;
        apartmentPrice = 68.7; break;
    case ("July"):
    case ("August"):
        studioPrice = 76;
        apartmentPrice = 77; break;
}
double totalStudio = nights * studioPrice;
double totalApartment = nights * apartmentPrice;

if (nights > 7 && nights <= 14 && (month == "May" || month == "October"))
{
    totalStudio *= 0.95;
}
else if (nights > 14)
{
    totalApartment *= 0.9;

    if (month == "May" || month == "October")
    {
        totalStudio *= 0.7;
    }
    else if (month == "June" || month == "September")
    {
        totalStudio *= 0.8;
    }
}

//Output
Console.WriteLine ($"Apartment: {totalApartment:f2} lv.");
Console.WriteLine($"Studio: {totalStudio:f2} lv.");