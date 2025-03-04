//Input
int hour = int.Parse(Console.ReadLine());
string day = Console.ReadLine();

//Calculations
if (hour >= 10 && hour < 18)
{
    switch (day)
    {
        case ("Monday"):
        case ("Tuesday"):
        case ("Wednesday"):
        case ("Thursday"):
        case ("Friday"):
        case ("Saturday"):
            Console.WriteLine("open");//Output
            break;
        default:
            Console.WriteLine("closed");//Output
            break;
    }
}
else
{
    Console.WriteLine("closed");//output
}
