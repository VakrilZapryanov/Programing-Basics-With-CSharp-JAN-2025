//Input
int dancers = int.Parse(Console.ReadLine());
double points = double.Parse(Console.ReadLine());
string season = Console.ReadLine();
string place = Console.ReadLine();

//Calculations
double prize = 0;
if (place == "Bulgaria")
{
    prize = points * dancers;

    switch (season)
    {
        case ("summer"): prize *= 0.95; break;
        case ("winter"): prize *= 0.92; break;
    }
}
else if (place == "Abroad")
{
    prize = points * dancers;
    prize *= 1.5;
    
    switch (season)
    {
        case ("summer"): prize *= 0.9; break;
        case ("winter"): prize *= 0.85; break;
    }
}

double moneyForCharity = prize * 0.75;
prize *= 0.25;

double prizePerPerson = prize / dancers;

//Output
Console.WriteLine($"Charity - {moneyForCharity:f2}");
Console.WriteLine($"Money per dancer - {prizePerPerson:f2}");