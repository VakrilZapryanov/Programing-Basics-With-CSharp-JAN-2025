//input
double depositSum = double.Parse(Console.ReadLine());
int depositPeriod = int.Parse(Console.ReadLine());
double precentPerYear = double.Parse(Console.ReadLine());
//calculations
double endSum = depositSum + depositPeriod * ((depositSum * precentPerYear / 100) / 12);
//output
Console.WriteLine(endSum);