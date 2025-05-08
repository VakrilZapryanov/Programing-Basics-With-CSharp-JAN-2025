//Input
double CPUPrice = double.Parse(Console.ReadLine());
double VideoCardPrice = double.Parse(Console.ReadLine());
double RAMPriceForOne = double.Parse(Console.ReadLine());
int RAMCount = int.Parse(Console.ReadLine());
double percentDiscount = double.Parse(Console.ReadLine());

//Calculations
double CPUPriceInLeva = CPUPrice * 1.57; //Without Discount
double VideoCardPriceInLeva = VideoCardPrice * 1.57; //Without Discount
double RAMPriceForOneInLeva = RAMPriceForOne * 1.57;
double RAMPriceTotal = RAMPriceForOneInLeva * RAMCount;

//Discount
CPUPriceInLeva -= CPUPriceInLeva * percentDiscount;
VideoCardPriceInLeva -= VideoCardPriceInLeva * percentDiscount;

double bill = CPUPriceInLeva + VideoCardPriceInLeva + RAMPriceTotal;

//Output
Console.WriteLine($"Money needed - {bill:f2} leva.");