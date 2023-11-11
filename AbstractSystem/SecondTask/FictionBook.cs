namespace AbstractSystem;

public class FictionBook: Book
{
    public FictionBook(string name, string author, int year): base(name, author, year)
    {
        
    }
    public override void GetInfo()
    {
        Console.WriteLine($"Book '{_name}' was written in {_year} by {_author}");
                           
    }
}