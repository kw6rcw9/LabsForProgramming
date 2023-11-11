using AbstractSystem;

List<Book> books = new List<Book>()
{
    new FictionBook("The Mysterious Island", "Jules Verne" ,1874),
    new ScientificBook("Matematica in pausa caffe", "Codogno Maurizio", 2020, "Mathematics")
};

foreach (Book book in books)
{
    book.GetInfo();
}