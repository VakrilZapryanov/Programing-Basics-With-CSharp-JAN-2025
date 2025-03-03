//Input
int lenghtInCM = int.Parse(Console.ReadLine());
int wideInCM = int.Parse(Console.ReadLine());
int hightInCM = int.Parse(Console.ReadLine());
double percent = double.Parse(Console.ReadLine()) / 100;

//Calculations
int volume = lenghtInCM * wideInCM * hightInCM;
double volumeInLiters = volume / 1000.0;
double takenSpace = volumeInLiters * percent;
double neededLiters = volumeInLiters - takenSpace;

//Output
Console.Write(neededLiters);