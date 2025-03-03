//Prices
double penPrice = 5.80;
double markerPrice = 7.20;
double cleanerPrice = 1.20;

//Input
int penPacketsCount = int.Parse(Console.ReadLine());
int markerPacketsCount = int.Parse(Console.ReadLine());
int cleanerLittersCount = int.Parse(Console.ReadLine());
int percentDiscount = int.Parse(Console.ReadLine());

//Calculations
double bill = (penPrice * penPacketsCount) + (markerPrice * markerPacketsCount) + (cleanerPrice * cleanerLittersCount);
double totalWithDiscount = bill - (bill * percentDiscount / 100);

//Output
Console.WriteLine(totalWithDiscount);