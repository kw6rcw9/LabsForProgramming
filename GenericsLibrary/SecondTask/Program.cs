// See https://aka.ms/new-console-template for more information

using SecondTask;

Book<int> book1 = new Book<int>(1,"Остров сокровищ", "Роберт Стивенсон", 350 );
Console.WriteLine(book1);
Book<string> book2 = new Book<string>("First","Остров сокровищ", "Роберт Стивенсон", 350 );
Console.WriteLine(book2);
Book<Guid> book3 = new Book<Guid>(Guid.NewGuid(),"Остров сокровищ", "Роберт Стивенсон", 350 );
Console.WriteLine(book3);
