//Input
int days = int.Parse(Console.ReadLine());
string typeOfRoom = Console.ReadLine();
string feedback = Console.ReadLine();

//Prices
int RoomForOnePrersonPrice = 18;
int apartmentPrice = 25;
int presidentApartmentPrice = 35;

//Calculations
double bill = 0;
int nights = days - 1;
switch (typeOfRoom)
{
    case ("room for one person"):
        bill = nights * RoomForOnePrersonPrice; break;
    case ("apartment"):
        bill = nights * apartmentPrice; break;
    case ("president apartment"):
        bill = nights * presidentApartmentPrice; break;
}
if (days < 10)
{
    switch (typeOfRoom)
    {
        case ("apartment"):
            bill *= 0.7; break;
        case ("president apartment"):
            bill *= 0.9; break;
    }
}
else if (days >= 10 && days <= 15)
{
    switch (typeOfRoom)
    {
        case ("apartment"):
            bill *= 0.65; break;
        case ("president apartment"):
            bill *= 0.85; break;
    }
}
else 
{
    switch (typeOfRoom)
    {
        case ("apartment"):
            bill *= 0.5; break;
        case ("president apartment"):
            bill *= 0.8; break;
    }
}

//feedback + / -
if (feedback == "positive")
{
    bill *= 1.25;
}
else if (feedback == "negative")
{
    bill *= 0.9;
}

//Output
Console.WriteLine($"{bill:f2}");