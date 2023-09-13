namespace SecondTask;

public class Book<T>
{
    private string? _name;
    private string? _author;
    private int _pagesCount;
    private T _id;

    public Book(T id, string name, string author, int pagesCount)
    {
        _name = name;
        _author = author;
        _pagesCount = pagesCount;
        _id = id;
    }

    public override string ToString()
    {
        return $"{_id} {_name}, {_author}, {_pagesCount} страниц";
    }
}