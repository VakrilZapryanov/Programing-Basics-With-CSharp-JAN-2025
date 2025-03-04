//Input
int age = int.Parse(Console.ReadLine());
double washingMashinePrice = double.Parse(Console.ReadLine());
int toyPrice = int.Parse(Console.ReadLine());

//Calculations
int toysCount = 0;
int moneyTotal = 0;
int moneyInTake = 0;

for (int currentAge = 1; currentAge <= age; currentAge++)
{
    if (currentAge % 2 == 1) 
    {
        toysCount++;
    }
    else
    {
        moneyInTake += 10;
        moneyTotal += moneyInTake;

        //Brother
        moneyTotal--;
    }
}

moneyTotal += toysCount * toyPrice;

//Output
if (moneyTotal >= washingMashinePrice)
{
    Console.WriteLine($"Yes! {moneyTotal - washingMashinePrice:f2}");
}

else
{
    Console.WriteLine($"No! {washingMashinePrice - moneyTotal:f2}");
}
