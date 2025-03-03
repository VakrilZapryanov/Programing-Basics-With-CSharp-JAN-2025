//Input
int firstPlayerTime = int.Parse(Console.ReadLine());
int secondPlayerTime = int.Parse(Console.ReadLine());
int thirdPlayerTime = int.Parse(Console.ReadLine());

//Calculations
int timeInSeconds = firstPlayerTime + secondPlayerTime + thirdPlayerTime;
int minutes = timeInSeconds / 60;
int seconds = timeInSeconds % 60;

//OutPut
if (minutes < 10)
    Console.WriteLine($"{minutes}:0{seconds}");

else
    Console.Write($"{minutes}:{seconds}");