//Input
int TotalSeaPackages = int.Parse(Console.ReadLine());
int TotalMountainPackages = int.Parse(Console.ReadLine());

//Prices
int seaPrice = 680;
int mountainPrice = 499;

//Calculations
int profit = 0;

string input = "";
while ((input = Console.ReadLine()) != "Stop")
{
    if (input == "sea" && TotalSeaPackages > 0)
    {
        profit += seaPrice;
        TotalSeaPackages--;
    }
    else if (input == "mountain" && TotalMountainPackages > 0)
    {
        profit += mountainPrice;
        TotalMountainPackages--;
    }

    if (TotalMountainPackages == 0 && TotalSeaPackages == 0)
    {
        Console.WriteLine("Good job! Everything is sold."); //Output
        break;
    }
}
//Output
Console.WriteLine($"Profit: {profit} leva.");