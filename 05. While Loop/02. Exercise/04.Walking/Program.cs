string input = Console.ReadLine();
int totalSteps = 0;

while (input != "Going home")
{
    int steps = int.Parse(input);
    totalSteps += steps;
    if (totalSteps >= 10000)
    {
        int overSteps = totalSteps - 10000;
        Console.WriteLine("Goal reached! Good job!");
        Console.WriteLine($"{overSteps} steps over the goal!");
        break;
    }
    input = Console.ReadLine();
}

if (input == "Going home")
{
    int stepsToHome = int.Parse(Console.ReadLine());
    totalSteps += stepsToHome;
    if (totalSteps >= 10000)
    {
        Console.WriteLine("Goal reached! Good job!");
        int overSteps = totalSteps - 10000;
        Console.WriteLine($"{overSteps} steps over the goal!");
    }
    else 
    {
        int moreStepsNeeded = 10000 - totalSteps;
        Console.WriteLine($"{moreStepsNeeded} more steps to reach goal.");
    }
}