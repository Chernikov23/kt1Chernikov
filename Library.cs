using System;
namespace MainProg
{
    public class Library : Building
{
    private string[] _books;
    public Library(string address, string[] books) : base(address)
    {
        if (books == null)
        {
            _books = [];
        }
        else
        {
            _books = books;
        }
    }
    public string[] Books
    {
        get { return _books; }
    }
}
}
