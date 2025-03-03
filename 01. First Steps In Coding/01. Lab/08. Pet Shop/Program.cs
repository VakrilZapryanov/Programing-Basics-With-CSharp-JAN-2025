int dogsFood = int.Parse(Console.ReadLine());
int catsFood = int.Parse(Console.ReadLine());

double dogsFoodPrice = dogsFood * 2.50;
int catsFoodPrice = catsFood * 4;

double totalPrice = dogsFoodPrice + catsFoodPrice;

Console.WriteLine($"{totalPrice} lv.");