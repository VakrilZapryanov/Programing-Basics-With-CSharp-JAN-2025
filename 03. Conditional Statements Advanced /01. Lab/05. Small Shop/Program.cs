﻿//Input
string product = Console.ReadLine();
string city = Console.ReadLine();
double quantity = double.Parse(Console.ReadLine());

double price = 0;

//Calculations
if (city == "Sofia")
{
    switch (product)
    {
        case "coffee":
            price = quantity * 0.5; break;
        case "water":
            price = quantity * 0.8; break;
        case "beer":
            price = quantity * 1.2; break;
        case "sweets":
            price = quantity * 1.45; break;
        case "peanuts":
            price = quantity * 1.6;break;
    }
}
else if (city == "Plovdiv")
{
    switch (product)
    {
        case "coffee":
            price = quantity * 0.4; break;
        case "water":
            price = quantity * 0.7; break;
        case "beer":
            price = quantity * 1.15; break;
        case "sweets":
            price = quantity * 1.3; break;
        case "peanuts":
            price = quantity * 1.5; break;
    }
}
else //Varna
{
    switch (product)
    {
        case "coffee":
            price = quantity * 0.45; break;
        case "water":
            price = quantity * 0.7; break;
        case "beer":
            price = quantity * 1.1; break;
        case "sweets":
            price = quantity * 1.35; break;
        case "peanuts":
            price = quantity * 1.55; break;
    }
}

//Output
Console.WriteLine(price);