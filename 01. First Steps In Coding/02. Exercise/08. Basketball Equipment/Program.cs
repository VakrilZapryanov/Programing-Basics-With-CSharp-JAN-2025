//Input
int yearfee = int.Parse(Console.ReadLine());

//Calculations
double basketballShoesPrice = yearfee - (yearfee * 0.40);
double equipmentPrice = basketballShoesPrice - (basketballShoesPrice * 0.20);
double basketballPrice = equipmentPrice / 4; 
double accesoriesPrice = basketballPrice / 5;
double totalPrice = yearfee + basketballShoesPrice + equipmentPrice + basketballPrice + accesoriesPrice;

//Output
Console.Write(totalPrice);