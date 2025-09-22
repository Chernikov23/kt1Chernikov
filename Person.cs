using System;

namespace MainProg
{
    public class Person
{
    private string _firstName;
    private string _lastName;
    private int _age;
    public Person(string firstName, string lastName, int age)
    {
        _firstName = firstName;
        _lastName = lastName;
        if (age < 0)
        {
            _age = 0;
        }
        else
        {
            _age = age;
        }
    }
    public string FirstName
    {
        get { return _firstName; }
    }

    public string LastName
    {
        get { return _lastName; }
    }

    public int Age
    {
        get { return _age; }
    }
}
}
