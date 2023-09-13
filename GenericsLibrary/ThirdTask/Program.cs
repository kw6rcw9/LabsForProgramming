// See https://aka.ms/new-console-template for more information
using SecondTask;
using ThirdTask;

GenericClass<int> ex1 = new GenericClass<int>(10);
Book<int> book = new Book<int>(1, "Остров сокровищ", "Роберт Стивенсон", 350);
GenericClass<Book<int>> ex2 = new GenericClass<Book<int>>(book);
Console.WriteLine($"{ex1.Value}, {ex2.Value}");
ex1.Reset();
ex2.Reset();
Console.WriteLine($"{ex1.Value}, {ex2.Value}");

