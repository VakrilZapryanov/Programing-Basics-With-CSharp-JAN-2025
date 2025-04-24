int floors = int.Parse(Console.ReadLine());
int rooms = int.Parse(Console.ReadLine());

for (int currentFloor = floors; currentFloor > 0; currentFloor--)
{
    char type;
    if (currentFloor == floors) type = 'L';
    else if (currentFloor % 2 == 0) type = 'O';
    else type = 'A';

    for (int currentRoom = 0; currentRoom < rooms; currentRoom++)
    {
        Console.Write($"{type}{currentFloor}{currentRoom} ");
    }
    Console.WriteLine();
}