int num = int.Parse(Console.ReadLine());

int sum = 0;

while (true)
{
    if (sum >= num)
    {
        Console.WriteLine(sum);
        break;
    }

    sum += int.Parse(Console.ReadLine());
}

//Console.WriteLine(sum);