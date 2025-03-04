//Input
double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();

//Calculations
string destination = "";
string typeOfVacation = "";
double spentAmount = 0;

if (budget <= 100)
{
    destination = "Bulgaria";

    switch(season)
    {
        case ("summer"):
            spentAmount = budget * 0.3;
            typeOfVacation = "Camp";
            break;
        case ("winter"):
            spentAmount = budget * 0.7;
            typeOfVacation = "Hotel";
            break;
    }
}
else if (budget <= 1000)
{
    destination = "Balkans";

    switch (season)
    {
        case ("summer"):
            spentAmount = budget * 0.4;
            typeOfVacation = "Camp";
            break;
        case ("winter"):
            spentAmount = budget * 0.8;
            typeOfVacation = "Hotel";
            break;
    }
}
else if (budget > 1000)
{
    destination = "Europe";
    typeOfVacation = "Hotel";

    switch (season)
    {
        case ("summer"):
        case ("winter"):
            spentAmount = budget * 0.9;
            break;
    }
}

//Output
Console.WriteLine($"Somewhere in {destination}");
Console.WriteLine($"{typeOfVacation} - {spentAmount:f2}");