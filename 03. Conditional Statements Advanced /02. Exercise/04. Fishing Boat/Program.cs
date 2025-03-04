//Input
int groupBudget = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
int fishersCount = int.Parse(Console.ReadLine());

//Prices
int springRent = 3000;
int summerAndAutumnRent = 4200;
int winterRent = 2600;

//Calculations
double bill = 0.0;
if (fishersCount <= 6)
{
    switch (season)
    {
        case ("Spring"):
            bill = springRent * 0.9; break;
        case ("Summer"):
        case ("Autumn"):
            bill = summerAndAutumnRent * 0.9; break;
        case ("Winter"):
            bill = winterRent * 0.9; break;
    }
}
else if (fishersCount >= 7 && fishersCount <= 11)
{
    switch(season)
    {
        case ("Spring"):
            bill = springRent * 0.85; break;
        case ("Summer"):
        case ("Autumn"):
            bill = summerAndAutumnRent * 0.85; break;
        case ("Winter"):
            bill = winterRent * 0.85; break;
    }
}
else if (fishersCount >= 12)
{
    switch (season)
    {
        case ("Spring"):
            bill = springRent * 0.75; break;
        case ("Summer"):
        case ("Autumn"):
            bill = summerAndAutumnRent * 0.75; break;
        case ("Winter"):
            bill = winterRent * 0.75; break;
    }
}
else if (fishersCount % 2 == 0)
{
    switch(season)
    {
        case ("Spring"):
        case ("Summer"):
        case ("Winter"):
            bill = bill * 0.95; break;
    }
}

//Output
if (groupBudget >= bill)
{
    double moneyLeft = groupBudget - bill;
    Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
}
else
{
    double neededMoney = bill - groupBudget;
    Console.WriteLine($"Not enough money! You need {neededMoney:f2} leva.");
}
