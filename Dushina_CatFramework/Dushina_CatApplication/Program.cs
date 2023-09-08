using System.Dynamic;
using Dushina_CatFramework;

uint catCount = uint.Parse(Console.ReadLine());
var cats = GenerateRandomCats(catCount);
DisplayCatInfo(cats);


Cat[] GenerateRandomCats(uint count)
{
    Random rnd = new Random();
    Cat[] cats = new Cat[count];
    for (int i = 0; i < count; i++)
    {
        int n = rnd.Next(0,2);
        bool again;
        switch (n)
        {
            case 0:
                do
                {
                    try
                    {
                        again = false;
                        cats[i] = new Tiger(rnd.Next(50, 160), rnd.Next(-20, 120));
                    }
                    catch (CatException e)
                    {
                        again = true;
                        Console.WriteLine($"{e.GetType()}: {e.Message}");
                    }
                } while (again);
                continue;
            case 1:
                do
                {
                    again = false;
                    try
                    {
                        cats[i] = new CuteCat(rnd.Next(-20, 120));
                    }
                    catch (CatException e)
                    {
                        again = true;
                        Console.WriteLine($"{e.GetType()}: {e.Message}");
                    }
                } while (again);
                continue;
        }
    }

    return cats;
}

void DisplayCatInfo(Cat[] catsArr)
{
    for (int i = 0; i < catsArr.Length; i++)
    {
        Console.WriteLine(catsArr[i].FluffinessCheck());
        Console.WriteLine(catsArr[i]);
        
    }
}