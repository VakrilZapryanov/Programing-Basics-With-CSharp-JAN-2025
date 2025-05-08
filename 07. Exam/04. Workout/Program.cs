//Input
int trainingDays = int.Parse(Console.ReadLine());
double kmFirstDay = double.Parse(Console.ReadLine());

//Calculations
double kmTotal = kmFirstDay;
for (int currentDay = 1; currentDay <= trainingDays; currentDay++)
{
    double percents = int.Parse(Console.ReadLine()) / 100.0;
    kmFirstDay += kmFirstDay * percents;
    kmTotal += kmFirstDay;
}

//Output
if (kmTotal >= 1000)
{
    double overRun = kmTotal - 1000;
    Console.WriteLine($"You've done a great job running {Math.Ceiling(overRun)} more kilometers!");
}
else // kmTotal < 1000 
{
    double kmMore = 1000 - kmTotal;
    Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {Math.Ceiling(kmMore)} more kilometers");
}