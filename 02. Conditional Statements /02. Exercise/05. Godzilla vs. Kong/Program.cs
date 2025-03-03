//Input
double budget = double.Parse(Console.ReadLine());
int backgroundActorsCount = int.Parse(Console.ReadLine());
double backgroundActorClothingPrice = double.Parse(Console.ReadLine());

//Prices
double decor = budget * 0.10;
if (backgroundActorsCount > 150)
{
    backgroundActorClothingPrice = backgroundActorClothingPrice -
        (backgroundActorClothingPrice * 0.1);
}

//Calculations
double total = backgroundActorClothingPrice * backgroundActorsCount + decor;

if(total>budget)
{
    Console.WriteLine("Not enough money!");//Output
    double moneyNeeded = (budget - total) * -1;
    Console.WriteLine($"Wingard needs {moneyNeeded:f2} leva more."); //Output
}
else
{
    Console.WriteLine("Action!");//Output
    double moneyLeft = budget - total;
    Console.WriteLine($"Wingard starts filming with {moneyLeft:f2} leva left.");//Output
}