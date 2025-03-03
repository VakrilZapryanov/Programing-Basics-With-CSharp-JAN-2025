//Input
string name = Console.ReadLine();
int epDuration = int.Parse(Console.ReadLine());
int breakDuration = int.Parse(Console.ReadLine());

//Calculations
double lunch = breakDuration / 8.0;
double freeTime = breakDuration / 4.0;

double neededTime = epDuration + lunch + freeTime;

//Output
if (neededTime<=breakDuration)
{
    double timeLeft = Math.Ceiling(breakDuration - neededTime);
    Console.Write($"You have enough time to watch {name} and left with {timeLeft} minutes free time.");
}
else
{
    double moreTimeNeeded = Math.Ceiling(neededTime - breakDuration);
    Console.Write($"You don't have enough time to watch {name}, you need {moreTimeNeeded} more minutes.");
}