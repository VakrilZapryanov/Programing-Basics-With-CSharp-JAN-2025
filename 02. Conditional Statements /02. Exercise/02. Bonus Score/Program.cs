﻿//Input
int number = int.Parse(Console.ReadLine());
double bonus = 0.0;

if(number<=100)
{
    bonus = 5;
}
else if(number<=1000)
{
    bonus = number * 0.2;
}
else
{
    bonus = number * 0.1;
}
double firstTotal = number + bonus;
double secondBonus = 0.00;

if(number %2 == 0 )
{
    secondBonus = 1;
}
else if (number % 10 == 5)
{
    secondBonus = 2;
}

Console.WriteLine(bonus + secondBonus);
Console.WriteLine(firstTotal + secondBonus);