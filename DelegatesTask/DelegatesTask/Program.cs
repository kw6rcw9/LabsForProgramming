using System.Diagnostics;
using DelegatesTask;



Calculation cal = new Calculation();
Console.WriteLine(cal.DelFac?.Invoke(10));
Console.WriteLine(cal.DelNumSum?.Invoke(223));
Console.WriteLine(cal.DelNumMult?.Invoke(223));
cal.DelPrintSum?.Invoke(223);
cal.DelPrintMult?.Invoke(223);
int a = 0, b = 0;
Console.WriteLine(cal.DelRemove?.Invoke(12345, out a, out b, true));
Console.WriteLine("{0},{1}", a,  b);

//4 task

DelegateNumMult delegateNumMult = cal.NumSum;
delegateNumMult += cal.NumMult;
Console.WriteLine("Делегат NumSum + NumMult");
Console.WriteLine(delegateNumMult?.Invoke(223));
// 5 task

DelegatesAbilities(223);


// 6 task
cal.MultiDelegate().Invoke(12345);

//7 task
int fact = cal.DelFac.Invoke(13);
Console.WriteLine(fact);
Console.WriteLine("Сумма: ");
cal.DelPrintSum?.Invoke(fact);
Console.WriteLine("Произведение: ");
cal.DelPrintMult?.Invoke(fact);



void DelegatesAbilities(int num)
{
    ConsoleKeyInfo key;
    DelegatePrintSum? del = null;
    Console.WriteLine("Нажмите клавишу 1 для добавления метода PrintSum,\n" +
                          " 2 для удаления метода PrintSum,\n" +
                          " 3 для добавления метода PrintMult\n" +
                          " 4 для удаления метода PrintMult\n" +
                          " 5 для вызова делегата\n" +
                          " Enter для выхода из программы\n");
    do
    {
       
        key = Console.ReadKey();
        Console.WriteLine();
        switch (key.Key)
        {
            case ConsoleKey.D1:
                del += cal.PrintSum;
                break;
            case ConsoleKey.D2:
                del -= cal.PrintSum;
                break;
            case ConsoleKey.D3:
                del += cal.PrintMult;
                break;
            case ConsoleKey.D4:
                del -= cal.PrintMult;
                break;
            case ConsoleKey.D5:
                if (del == null)
                {
                    Console.WriteLine("Делегат пуст");
                    break;
                }
                Console.WriteLine("Вызов делегата");
                del?.Invoke(num);
                break;
   
        }

    }while(key.Key != ConsoleKey.Enter);
    
}


