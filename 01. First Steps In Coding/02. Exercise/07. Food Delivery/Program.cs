//Prices
double chickenMenu = 10.35;
double fishMenu = 12.40;
double veganMenu = 8.15;
double delivery = 2.50;

//Input
int chickenMenuCount = int.Parse(Console.ReadLine());
int fishMenuCount = int.Parse(Console.ReadLine());
int veganMenuCount = int.Parse(Console.ReadLine());

//Calculations
double chickenMenusPrice = chickenMenu * chickenMenuCount;
double fishMenusPrice = fishMenu * fishMenuCount;
double veganMenusPrice = veganMenu * veganMenuCount;
double totalMenuPrice = chickenMenusPrice + fishMenusPrice + veganMenusPrice;

double desserts = totalMenuPrice * 0.2;

double bill = totalMenuPrice + desserts + delivery;

//Output
Console.WriteLine(bill);