//Input
double input = double.Parse(Console.ReadLine()) * 100;

//Calculations
int change = (int)Math.Round(input);
int coinsCounter = 0;

while (change > 0)
{
    if (change - 200 >= 0)
    {
        coinsCounter++;
        change -= 200;
    }
    else if (change - 100 >= 0)
    {
        coinsCounter++;
        change -= 100;
    }
    else if (change - 50 >= 0)
    {
        coinsCounter++;
        change -= 50;
    }
    else if (change - 20 >= 0)
    {
        coinsCounter++;
        change -= 20;
    }
    else if (change - 10 >= 0)
    {
        coinsCounter++;
        change -= 10;
    }
    else if (change - 5 >= 0)
    {
        coinsCounter++;
        change -= 5;
    }
    else if (change - 2 >= 0)
    {
        coinsCounter++;
        change -= 2;
    }
    else if (change - 1 >= 0)
    {
        coinsCounter++;
        change -= 1;
    }
}

//Output
Console.WriteLine(coinsCounter);