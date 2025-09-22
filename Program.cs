using System;

namespace MainProg
{
    class Program
{
    static void Main(string[] args)
    {
        string[] books = { "1984", "О, Дивный новый мир", "Скотный двор" };
        Library library = new Library("Московский просп. 165", books);

        Reader reader = new Reader("Александр", "Черников", 17);
        reader.ReadBook(library, "1984");
        reader.ReadBook(library, "Мастер и Маргарита");
        reader.ReadBook(library, "Скотный двор");
        reader.ReadBook(library, "");
    }
}   
}
