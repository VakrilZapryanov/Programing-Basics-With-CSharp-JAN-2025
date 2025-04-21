//Input
int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
string input = "";

//Calculations
int freeSpace = width * length * height;

while ((input = Console.ReadLine()) != "Done")
{
    int cartons = int.Parse(input);
    freeSpace -= cartons;

    if (freeSpace <= 0)
    {
        //Output
        Console.WriteLine($"No more free space! You need {Math.Abs(freeSpace)} Cubic meters more.");
        break;
    }
}

//Output
if (input == "Done")
{
    Console.WriteLine($"{freeSpace} Cubic meters left.");
}