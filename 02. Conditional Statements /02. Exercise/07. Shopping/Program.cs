//Input
double budjet = double.Parse(Console.ReadLine());
int NCount = int.Parse(Console.ReadLine());
int MCount = int.Parse(Console.ReadLine());
int PCount = int.Parse(Console.ReadLine());

//Prices
int NPrice = 250;
double MPrice = (NCount * NPrice) * 0.35;
double PPrice = (NCount * NPrice) * 0.1;

//Calculations
double total = NPrice * NCount + MPrice * MCount + PPrice * PCount;
if (NCount > MCount)
{
    total = total - (total * 0.15);
}

//Output
if (total <= budjet)
{
    double moneyLeft = budjet - total;
    Console.Write($"You have {moneyLeft:f2} leva left!");
}
else
{
    double moneyNeeded = total - budjet;
    Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva more!");
}