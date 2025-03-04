//Input
string city = Console.ReadLine();
double sels = double.Parse(Console.ReadLine());

//Calculations
double commissions = 0.0;
if (sels >= 0 && sels <= 500)
{
    switch (city)
    {
        case ("Sofia"):
            commissions = sels * 0.05;
            Console.WriteLine($"{commissions:f2}"); break;
        case ("Varna"):
            commissions = sels * 0.045;
            Console.WriteLine($"{commissions:f2}"); break;
        case ("Plovdiv"):
            commissions = sels * 0.055;
            Console.WriteLine($"{commissions:f2}"); break;
        default:
            Console.WriteLine("error"); break;
    }
}
else if (sels > 500 && sels <= 1000)
{
    switch (city)
    {
        case ("Sofia"):
            commissions = sels * 0.07;
            Console.WriteLine($"{commissions:f2}"); break;
        case ("Varna"):
            commissions = sels * 0.075;
            Console.WriteLine($"{commissions:f2}"); break;
        case ("Plovdiv"):
            commissions = sels * 0.08;
            Console.WriteLine($"{commissions:f2}"); break;
        default:
            Console.WriteLine("error"); break;
    }
}
else if (sels > 1000 && sels <= 10000)
{
    switch (city)
    {
        case ("Sofia"):
            commissions = sels * 0.08;
            Console.WriteLine($"{commissions:f2}"); break;
        case ("Varna"):
            commissions = sels * 0.10;
            Console.WriteLine($"{commissions:f2}"); break;
        case ("Plovdiv"):
            commissions = sels * 0.12;
            Console.WriteLine($"{commissions:f2}"); break;
        default:
            Console.WriteLine("error"); break;
    }
}
else if (sels > 10000)
{
    switch (city)
    {
        case ("Sofia"):
            commissions = sels * 0.12;
            Console.WriteLine($"{commissions:f2}"); break;
        case ("Varna"):
            commissions = sels * 0.13;
            Console.WriteLine($"{commissions:f2}"); break;
        case ("Plovdiv"):
            commissions = sels * 0.145;
            Console.WriteLine($"{commissions:f2}"); break;
        default:
            Console.WriteLine("error"); break;
    }
}
else
    Console.WriteLine("error");