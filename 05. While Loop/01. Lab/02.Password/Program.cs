//Input
string username = Console.ReadLine();
string password = Console.ReadLine();

string input = Console.ReadLine();

//Calculations
while (input != password)
{
    input = Console.ReadLine();
}

//Output
Console.WriteLine($"Welcome {username}!");