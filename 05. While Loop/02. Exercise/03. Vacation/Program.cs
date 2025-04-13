//Input
double moneyForExcursion = double.Parse(Console.ReadLine());
double cash = double.Parse(Console.ReadLine());

//Calculations
int spendDaysCount = 0;
int totalDaysCount = 0;
double moneySum = cash;


while (true)
{
    string action = Console.ReadLine(); 
    double newMoney = double.Parse(Console.ReadLine()); 

    if (action == "spend") 
    {
        spendDaysCount++;
        totalDaysCount++;
        if (spendDaysCount == 5)
        {
            //Output
            Console.WriteLine("You can't save the money.");
            Console.WriteLine(totalDaysCount);
            break;
        }

        if (newMoney > moneySum)
        {
            moneySum = 0;
        }
        if (newMoney <= moneySum)
        {
            moneySum -= newMoney;
        }
    }

    else if (action == "save") 
    {
        spendDaysCount = 0;
        totalDaysCount++;
        moneySum += newMoney;

        if (moneySum >= moneyForExcursion) 
        {
            //Output
            Console.WriteLine($"You saved the money for {totalDaysCount} days.");
            break;
        }
    }
}