//Input
int allowPoorGrades = int.Parse(Console.ReadLine());

//Calculations
int probelmsCount = 0;
string lastProblemName = "";
int poorGrades = 0;
int gradeSum = 0;

while (true)
{
    string problemName = Console.ReadLine();
    if (problemName != "Enough")
    {
        probelmsCount++;
        lastProblemName = problemName;
        int grade = int.Parse(Console.ReadLine());

        if (grade <= 4)
        {
            poorGrades++;
            if (poorGrades >= allowPoorGrades)
            {
                Console.WriteLine($"You need a break, {poorGrades} poor grades.");// Output
                break;
            }
            gradeSum += grade;
            continue;
        }
        if (grade > 4)
        {
            gradeSum += grade;
        }
    }

    if (problemName == "Enough")
    {
        Console.WriteLine($"Average score: {(double)gradeSum / probelmsCount:f2}");
        Console.WriteLine($"Number of problems: {probelmsCount}");
        Console.WriteLine($"Last problem: {lastProblemName}");
        break;
    }
}
