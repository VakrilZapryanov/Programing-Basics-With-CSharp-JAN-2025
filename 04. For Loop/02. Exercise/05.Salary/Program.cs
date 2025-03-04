//Input
int tabs = int.Parse(Console.ReadLine());
int salary = int.Parse(Console.ReadLine());

//Calculations
string websiteName = "";
for (int i = 1; i <= tabs; i++)
{
    websiteName = Console.ReadLine();

    if (websiteName == "Facebook")
        salary -= 150;
    else if (websiteName == "Instagram")
        salary -= 100;
    else if (websiteName == "Reddit")
        salary -= 50;
}

//Output
if (salary <= 0)
{
    Console.WriteLine("You have lost your salary.");
}
else // salary > 0
{
    Console.WriteLine(salary);
}