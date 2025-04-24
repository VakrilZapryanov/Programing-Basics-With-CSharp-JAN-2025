//string input = Console.ReadLine();
//
//while (input != "End")
//{
//    double prise = int.Parse(Console.ReadLine());
//    double money = 0;
//
//    while (money < prise)
//    {
//        money += double.Parse(Console.ReadLine());
//    }
//
//    Console.WriteLine($"Going to {input}!");
//
//    input = Console.ReadLine();
//}
string destination = Console.ReadLine();

while (destination != "End")
{
    double budget = double.Parse(Console.ReadLine());
    double money = 0;

    while (money < budget)
    {
        money += double.Parse(Console.ReadLine());
    }
    Console.WriteLine($"Going to {destination}!");

    destination = Console.ReadLine();
}