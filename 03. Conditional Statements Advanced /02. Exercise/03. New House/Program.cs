//Input
string typeOfFlower = Console.ReadLine();
int countOfFlowers = int.Parse(Console.ReadLine());
int budjet = int.Parse(Console.ReadLine());

//Prices
double rosesPrice = 5;
double dahliasPrice = 3.8;
double tulipsPrice = 2.8;
double narcissusPrice = 3;
double gladiolusPrice = 2.5;

//Calculations
double bill = 0.0;

if (typeOfFlower == "Roses")
{
    bill = countOfFlowers * rosesPrice;
    if(countOfFlowers > 80)
    {
        bill = bill * 0.9; //bill = bill - (bill * 0.1);
    }
}
else if (typeOfFlower == "Dahlias")
{
    bill = countOfFlowers * dahliasPrice;
    if (countOfFlowers > 90)
    {
        bill = bill * 0.85; //bill = bill - (bill * 0.15);
    }
}
else if (typeOfFlower == "Tulips")
{
    bill = countOfFlowers * tulipsPrice;
    if (countOfFlowers > 80)
    {
        bill = bill * 0.85; //bill = bill - (bill * 0.15);
    }
}
else if (typeOfFlower == "Narcissus")
{
    bill = countOfFlowers * narcissusPrice;
    if (countOfFlowers < 120)
    {
        bill = bill * 1.15; // bill = bill + (bill * 0.15);
    }
}
else if (typeOfFlower == "Gladiolus")
{
    bill = countOfFlowers * gladiolusPrice;
    if (countOfFlowers < 80)
    {
        bill = bill * 1.2;
    }
}

//Output
if (budjet >= bill)
{
    double moneyLeft = budjet - bill;
    Console.WriteLine($"Hey, you have a great garden with {countOfFlowers} {typeOfFlower} and {moneyLeft:f2} leva left.");
}
else
{
    double moneyNeeded = bill - budjet;
    Console.WriteLine($"Not enough money, you need {moneyNeeded:f2} leva more.");
}