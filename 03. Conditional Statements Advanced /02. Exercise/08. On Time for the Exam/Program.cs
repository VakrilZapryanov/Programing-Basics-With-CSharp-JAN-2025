//Input
int hourExam = int.Parse(Console.ReadLine());
int minutesExam = int.Parse(Console.ReadLine());
int hourArriving = int.Parse(Console.ReadLine());
int minutesArriving = int.Parse(Console.ReadLine());

//Calculations
int examTimeInMin = hourExam * 60 + minutesExam;
int arrivingTimeInMinutes = hourArriving * 60 + minutesArriving;

if (examTimeInMin < arrivingTimeInMinutes) //Закъснял
{
    Console.WriteLine("Late");//Output
    int minutesLate = arrivingTimeInMinutes - examTimeInMin;

    if (minutesLate <= 59)
    {
        Console.WriteLine($"{minutesLate} minutes after the start");//Output
    }
    else
    {
        double hoursLate = minutesLate / 60; //час
        minutesLate = minutesLate % 60; //мин

        if (minutesLate < 10)
        {
            Console.WriteLine($"{hoursLate}:0{minutesLate} hours after the start");//Output
        }
        else // minutesLate >= 10
        {
            Console.WriteLine($"{hoursLate}:{minutesLate} hours after the start");//Output
        }
    }
}
else //Early or Exactly ON TIME
{
    int minutesBefore = examTimeInMin - arrivingTimeInMinutes;
    if (minutesBefore == 0) //Exactly ON TIME
    {
        Console.WriteLine("On time");//Output
    }
    else if (minutesBefore <= 30 && minutesBefore > 0) //up to 30 min
    {
        Console.WriteLine("On time");//Output
        Console.WriteLine($"{minutesBefore} minutes before the start");//Output
    }
    else // early
    {
        Console.WriteLine("Early");//Output

        if (minutesBefore > 30 && minutesBefore <= 59)
        {
            Console.WriteLine($"{minutesBefore} minutes before the start");//Output
        }
        else // 1:xx
        {
            int hoursBefore = minutesBefore / 60;
            minutesBefore = minutesBefore % 60;
            if (minutesBefore < 10)
            {
                Console.WriteLine($"{hoursBefore}:0{minutesBefore} hours before the start");//Output
            }
            else // minutesBefore >= 10
            {
                Console.WriteLine($"{hoursBefore}:{minutesBefore} hours before the start"); //Output
            }
        }
    }
}



