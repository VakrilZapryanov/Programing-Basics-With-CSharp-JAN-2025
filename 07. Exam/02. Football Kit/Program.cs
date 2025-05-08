//Input
double TshirtPrice = double.Parse(Console.ReadLine());
double sumForBall = double.Parse(Console.ReadLine());

//Calculations
double shortsPrice = TshirtPrice * 0.75;
double socksPrice = shortsPrice * 0.2;
double sneakersPrice = (TshirtPrice + shortsPrice) * 2;

double bill = TshirtPrice + shortsPrice + socksPrice + sneakersPrice;

bill *= 0.85; //Discount

//Output
if (bill >= sumForBall)
{
    Console.WriteLine("Yes, he will earn the world-cup replica ball!");
    Console.WriteLine($"His sum is {bill:f2} lv.");
}
else
{
    Console.WriteLine("No, he will not earn the world-cup replica ball.");
    Console.WriteLine($"He needs {sumForBall - bill:f2} lv. more.");
}
