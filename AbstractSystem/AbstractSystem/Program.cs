using AbstractSystem;

List<Employee> employees = new List<Employee>()
{
    new Admin(100000),
    new Manager(80000),
    new Worker(60000)
};
List<Book> books = new List<Book>()
{
    new FictionBook("The Mysterious Island", "Jules Verne" ,1874),
    new ScientificBook("Matematica in pausa caffe", "Codogno Maurizio", 2020, "Mathematics")
};
foreach (Employee employee in employees)
{
    employee.CalculateSalary();
}
foreach (Book book in books)
{
    book.GetInfo();
}