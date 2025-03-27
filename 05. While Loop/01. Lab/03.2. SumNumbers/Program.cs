int num = int.Parse(Console.ReadLine());

int sum = 0;

while (true)
{
    if (sum < num)
        sum += int.Parse(Console.ReadLine());
    else
        break;
}

Console.WriteLine(sum);