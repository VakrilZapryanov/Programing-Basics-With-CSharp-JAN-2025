//prices
double nylonPrice = 1.50;
double paintPrice = 14.50;
double tinnerPrice = 5.00;
double bags = 0.40;

//Input
int nylonNeeded = int.Parse(Console.ReadLine());
int paintNeeded = int.Parse(Console.ReadLine());
int tinnerNeeded = int.Parse(Console.ReadLine());
int neededHours = int.Parse(Console.ReadLine());

//Calculations
double nylon = (nylonNeeded + 2) * nylonPrice;
double paint = (paintNeeded + paintNeeded *0.1) * paintPrice;
double tinner = tinnerNeeded * tinnerPrice;
double materialsPrice = nylon + paint + tinner + bags;

double workMensPrice = (materialsPrice * 0.30) * neededHours;
double totalSum = materialsPrice + workMensPrice;

//Output
Console.WriteLine(totalSum);