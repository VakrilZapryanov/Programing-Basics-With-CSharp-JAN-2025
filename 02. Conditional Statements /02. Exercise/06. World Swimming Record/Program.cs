//Input
double recordInSec = double.Parse(Console.ReadLine());
double distanceInMeters = double.Parse(Console.ReadLine());
double timeInSecForOneMeter = double.Parse(Console.ReadLine());

//Calculations
double timeInSecForDistance = timeInSecForOneMeter * distanceInMeters;
double resistanceTime = (Math.Floor(distanceInMeters / 15)) * 12.5;
double totalTime = timeInSecForDistance + resistanceTime;

//Output
if (totalTime < recordInSec)
{
    Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
}
else
{
    double missingTime = totalTime - recordInSec;
    Console.WriteLine($"No, he failed! He was {missingTime:f2} seconds slower.");
}