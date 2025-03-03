//input
int AllPages = int.Parse(Console.ReadLine());
int PagesForHour = int.Parse(Console.ReadLine());
int DaysForReading = int.Parse(Console.ReadLine());
//calculations
int HoursPerDay = AllPages / PagesForHour/ DaysForReading;
//Output
Console.WriteLine(HoursPerDay);
