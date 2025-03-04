int n = int.Parse(Console.ReadLine());

int minNumber = int.MaxValue;
int maxNumber = int.MinValue;

for (int i = 1; i <= n; i++)
{
    int num = int.Parse(Console.ReadLine());

    if (num > maxNumber)
        maxNumber = num;

    if (num < minNumber)
        minNumber = num;
}
Console.WriteLine("Max number: " + maxNumber);
Console.WriteLine("Min number: " + minNumber);
