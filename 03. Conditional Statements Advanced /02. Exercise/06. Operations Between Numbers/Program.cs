//Input
int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
string symbol = Console.ReadLine(); //„+“, „-“, „*“, „/“, „%“

//Calculations
double result = 0;
string oddOrEven = "";

if (symbol == "+")
{
    result = n1 + n2;
    if(result % 2 == 0)
    {
        oddOrEven = "even";
    }
    else
    {
        oddOrEven = "odd";
    }
}
else if (symbol == "-")
{
    result = n1 - n2;
    if (result % 2 == 0)
    {
        oddOrEven = "even";
    }
    else
    {
        oddOrEven = "odd";
    }
}
else if (symbol == "*")
{
    result = n1 * n2;
    if (result % 2 == 0)
    {
        oddOrEven = "even";
    }
    else
    {
        oddOrEven = "odd";
    }
}
else if (symbol == "/" && n2 != 0)
{
        result = n1 / (double)n2;
}
else if (symbol == "/" && n2 == 0)
{
    Console.WriteLine($"Cannot divide {n1} by zero"); //Output
}

else if (symbol == "%" && n2 != 0)
{
        result = n1 % n2;
}
else if (symbol == "%" && n2 == 0)
{
    Console.WriteLine($"Cannot divide {n1} by zero"); //Output
}


//Output
if (symbol == "+")
    Console.WriteLine($"{n1} + {n2} = {result} - {oddOrEven}"); 
else if (symbol == "-")
    Console.WriteLine($"{n1} - {n2} = {result} - {oddOrEven}"); 
else if (symbol == "*")
    Console.WriteLine($"{n1} * {n2} = {result} - {oddOrEven}"); 
else if (symbol == "/" && n2 != 0)
    Console.WriteLine($"{n1} / {n2} = {result:f2}"); 
else if (symbol == "%" && n2 != 0)
    Console.WriteLine($"{n1} % {n2} = {result}");
