//Input
string product = Console.ReadLine();

//Calculations
switch (product)
{
    case ("banana"):
    case ("apple"):
    case ("kiwi"):
    case ("cherry"):
    case ("lemon"):
    case ("grapes"):
        Console.WriteLine("fruit");break;//Output
    case ("tomato"):
    case ("cucumber"):
    case ("pepper"):
    case ("carrot"):
        Console.WriteLine("vegetable"); break;//Output
    default:
        Console.WriteLine("unknown"); break;//Output
}