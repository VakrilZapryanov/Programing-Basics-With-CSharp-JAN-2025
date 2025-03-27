string bookName = Console.ReadLine(); 

int bookCount = 0;

while (true)
{
    string currentBookName = Console.ReadLine(); 
    bookCount++; 

    if (currentBookName == bookName) 
    {
        bookCount--;
        Console.WriteLine($"You checked {bookCount} books and found it.");
        break;
    }

    if (currentBookName == "No More Books") 
    {
        bookCount--; 
        Console.WriteLine("The book you search is not here!");
        Console.WriteLine($"You checked {bookCount} books.");
        break;
    }
}
