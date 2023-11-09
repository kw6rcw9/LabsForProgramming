namespace AbstractSystem;

public abstract class Book
{
    protected string _name;
    protected string _author;
    protected int _year;

    public Book(string name, string author, int year)
    {
        _name = name;
        _author = author;
        _year = year;
    }
    public abstract void GetInfo();
}