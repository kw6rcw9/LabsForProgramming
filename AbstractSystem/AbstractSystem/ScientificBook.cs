namespace AbstractSystem;

public class ScientificBook: Book
{
    private string _scientificTopic;
    public ScientificBook(string name, string author, int year, string scientificTopic): base(name, author, year)
    {
        _scientificTopic = scientificTopic;
    }
    public override void GetInfo()
    {
        Console.WriteLine($"Book '{_name}' was written in {_year} by {_author} \n" +
                          $"The main topic ws {_scientificTopic} ");
    }
}