//Input
int K = int.Parse(Console.ReadLine());
int L = int.Parse(Console.ReadLine());
int M = int.Parse(Console.ReadLine());
int N = int.Parse(Console.ReadLine());

//Calculations
int count = 0;
for (int first1 = K; first1 <= 8; first1++)
{
    for (int second1 = 9; second1 >= L; second1--)
    {
        for (int first2 = M; first2 <= 8; first2++)
        {
            for (int second2 = 9; second2 >= N; second2--)
            {
                if (first1 % 2 == 0 && second1 % 2 != 0 && first2 % 2 == 0 && second2 % 2 != 0)
                {
                    if (first1 == first2 && second1 == second2)
                    {
                        Console.WriteLine("Cannot change the same player.");
                    }
                    else
                    {
                        Console.WriteLine($"{first1}{second1} - {first2}{second2}");
                        count++;
                    }

                    if (count == 6)
                    {
                        return;
                    }
                }
            }
        }
    }
}