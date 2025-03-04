//Input
string fruit = Console.ReadLine();
string day = Console.ReadLine();
double quantity = double.Parse(Console.ReadLine());

//Calculations
if (fruit == "banana")
{
    switch (day)
    {
        case ("Monday"):
        case ("Tuesday"):
        case ("Wednesday"):
        case ("Thursday"):
        case ("Friday"):
            double bananaPr = 2.5;
            double bill = bananaPr * quantity;
            Console.WriteLine($"{bill:f2}");
            break; //Output
        case ("Saturday"):
        case ("Sunday"):
            bananaPr = 2.7;
            double bill2 = bananaPr * quantity;
            Console.WriteLine($"{bill2:f2}");
            break;//Output
        default:
            Console.WriteLine("error");
            break;//Output

    }
}
else if (fruit == "apple")
{
    switch (day)
    {
        case ("Monday"):
        case ("Tuesday"):
        case ("Wednesday"):
        case ("Thursday"):
        case ("Friday"):
            double applePr = 1.2;
            double bill = applePr * quantity;
            Console.WriteLine($"{bill:f2}");
            break;//Output
        case ("Saturday"):
        case ("Sunday"):
            applePr = 1.25;
            double bill2 = applePr * quantity;
            Console.WriteLine($"{bill2:f2}");
            break;//Output
        default:
            Console.WriteLine("error");
            break;//Output
    }
}
else if (fruit == "orange")
{
    switch (day)
    {
        case ("Monday"):
        case ("Tuesday"):
        case ("Wednesday"):
        case ("Thursday"):
        case ("Friday"):
            double orangePr = 0.85;
            double bill = orangePr * quantity;
            Console.WriteLine($"{bill:f2}");
            break;//Output
        case ("Saturday"):
        case ("Sunday"):
            orangePr = 0.90;
            double bill2 = orangePr * quantity;
            Console.WriteLine($"{bill2:f2}");
            break;//Output
        default:
            Console.WriteLine("error");
            break;//Output
    }
}
else if (fruit == "grapefruit")
{
    switch (day)
    {
        case ("Monday"):
        case ("Tuesday"):
        case ("Wednesday"):
        case ("Thursday"):
        case ("Friday"):
            double grapefruitPr = 1.45;
            double bill = grapefruitPr * quantity;
            Console.WriteLine($"{bill:f2}");
            break;//Output
        case ("Saturday"):
        case ("Sunday"):
            grapefruitPr = 1.60;
            double bill2 = grapefruitPr * quantity;
            Console.WriteLine($"{bill2:f2}");
            break;//Output
        default:
            Console.WriteLine("error");
            break;//Output
    }
}
else if (fruit == "kiwi")
{
    switch (day)
    {
        case ("Monday"):
        case ("Tuesday"):
        case ("Wednesday"):
        case ("Thursday"):
        case ("Friday"):
            double kiwiPr = 2.7;
            double bill = kiwiPr * quantity;
            Console.WriteLine($"{bill:f2}");
            break;//Output
        case ("Saturday"):
        case ("Sunday"):
            kiwiPr = 3.00;
            double bill2 = kiwiPr * quantity;
            Console.WriteLine($"{bill2:f2}");
            break;//Output
        default:
            Console.WriteLine("error");
            break;//Output
    }
}
else if (fruit == "pineapple")
{
    switch (day)
    {
        case ("Monday"):
        case ("Tuesday"):
        case ("Wednesday"):
        case ("Thursday"):
        case ("Friday"):
            double pineapplePr = 5.5;
            double bill = pineapplePr * quantity;
            Console.WriteLine($"{bill:f2}");
            break;//Output
        case ("Saturday"):
        case ("Sunday"):
            pineapplePr = 5.6;
            double bill2 = pineapplePr * quantity;
            Console.WriteLine($"{bill2:f2}");
            break;//Output
        default:
            Console.WriteLine("error");
            break;//Output
    }
}
else if (fruit == "grapes")
{
    switch (day)
    {
        case ("Monday"):
        case ("Tuesday"):
        case ("Wednesday"):
        case ("Thursday"):
        case ("Friday"):
            double grapesPr = 3.85;
            double bill = grapesPr * quantity;
            Console.WriteLine($"{bill:f2}");
            break;//Output
        case ("Saturday"):
        case ("Sunday"):
            grapesPr = 4.2;
            double bill2 = grapesPr * quantity;
            Console.WriteLine($"{bill2:f2}");
            break;//Output
        default:
            Console.WriteLine("error");
            break;
    }
}
else
    Console.WriteLine("error"); 