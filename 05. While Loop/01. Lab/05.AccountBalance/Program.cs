string increase = Console.ReadLine();
double total = 0.0;

while (increase != "NoMoreMoney")
{
    double money = double.Parse(increase);

    if (money < 0)
    {
        Console.WriteLine("Invalid operation!");
        Console.WriteLine($"Total: {total:f2}");
        break;
    }

    total += money;
    Console.WriteLine($"Increase: {money:f2}");
    increase = Console.ReadLine();
}

if (increase == "NoMoreMoney")
{
    Console.WriteLine($"Total: {total:f2}");
}

