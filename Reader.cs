using System;

namespace MainProg
{
    public class Reader : Person
{
    public Reader(string firstName, string lastName, int age)
        : base(firstName, lastName, age) { }
    public void ReadBook(Library library, string bookName)
    {
        if (library == null)
        {
            Console.WriteLine("бибилотека не указана");
            return;
        }
        if (bookName == null || bookName == string.Empty)
        {
            Console.WriteLine("нет названия книгии");
            return;
        }
        bool bookFound = false;
        foreach (string book in library.Books)
        {
            if (book == bookName)
            {
                bookFound = true;
                break;
            }
        }
        if (bookFound)
        {
            Console.WriteLine($"Читатель {FirstName} {LastName} прочитал книгу {bookName}");
        }
        else
        {
            Console.WriteLine($"книга «{bookName}» не найдена в библиотеке");
        }
    }
}
}
