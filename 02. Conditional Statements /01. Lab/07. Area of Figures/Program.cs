﻿using System.Drawing;

string figure = Console.ReadLine();
double area;

if (figure == "square")
{
    double a = double.Parse(Console.ReadLine());
    area = a * a;
}
else if (figure== "rectangle")
{
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    area = a * b;
}
else if (figure== "circle")
{
    double r = double.Parse(Console.ReadLine());
    area = Math.PI * r * r;
}
else
{
    double a = double.Parse(Console.ReadLine());
    double hA = double.Parse(Console.ReadLine());
    area = a * hA / 2;
}
Console.WriteLine($"{area:f3}");