namespace DelegatesTask;
using MathNet.Numerics;

public delegate void RefDel( int num);
public delegate int DelegateFactorial( int num);
public delegate int DelegateNumSum(int num);
public delegate int DelegateNumMult(int num);

public delegate void DelegatePrintSum(int num);
public delegate void DelegatePrintMult(int num);
public delegate bool DelegateRemove( int num, out int oddsAmount, out int result, bool oddsNeeded);
public delegate int GenericDelNumSum<T>(T num);
public delegate int GenericDelNumMult<T>(T num);

public delegate T GenericDelFac<T>(T num);
public delegate void GenericDelPrintSum<T>(T num);
public delegate void GenericDelPrintMult<T>(T num);
public class Calculation
{
    public DelegateRemove? DelRemove;
    public DelegateFactorial? DelFac;
    public DelegateNumSum? DelNumSum;
    public DelegateNumMult? DelNumMult;
    public DelegatePrintSum? DelPrintSum;
    public DelegatePrintMult? DelPrintMult;
    public GenericDelNumSum<float>? GenericDelSum;
    public GenericDelNumMult<float>? GenericDelMult;
    public GenericDelPrintSum<float>? GenericDelPrintSum;
    public GenericDelPrintMult<float>? GenericDelPrintMult;
    public GenericDelFac<float>? GenericDelFactorial;

    public Calculation()
    {
        DelRemove = RemoveOdd;
        DelFac = Factorial;
        DelNumMult = NumMult;
        DelNumSum = NumSum;
        DelPrintMult = PrintMult;
        DelPrintSum = PrintSum;
        GenericDelSum = NumSum;
        GenericDelMult = NumMult;
        GenericDelPrintMult = PrintMult;
        GenericDelPrintSum = PrintSum;
        GenericDelFactorial = Factorial;

    }

    public RefDel MultiDelegate()
    {
        RefDel del;
        del = PrintMultNotOdds;
        del += PrintMultOdds;

        return del;


    }

    private void PrintMultOdds( int num)
    {
        int a, b;
        RemoveOdd(num, out a, out b, true);
        PrintMult(b);
        
    }
    private void PrintMultNotOdds( int num)
    {
        int a, b;
        RemoveOdd(num, out a, out b,false);
        PrintSum(b);
        
    }
    public int Factorial( int num)
    {
        if (num == 1)
            return 1;
        return num * Factorial( num - 1);
    }
    public float Factorial(float num)
    {

        double r = num;
        r *= SpecialFunctions.Gamma(num);
        return Convert.ToSingle(r);
    }

    public int NumSum(int num)
    {
        string newNum = num.ToString();
        int sum = 0;
        for (int i = 0; i < newNum.Length; i++)
            sum += int.Parse(newNum[i].ToString());
        
        return sum;
    }
    public int NumSum(float num)
    {
        string newNum = num.ToString().Replace(",", string.Empty);
        int sum = 0;
        for (int i = 0; i < newNum.Length; i++)
        {
            sum += int.Parse(newNum[i].ToString());
        }
        
        return sum;
    }

    public int NumMult(int num)
    {
        string newNum = num.ToString();
        int mult = 1;
        for (int i = 0; i < newNum.Length; i++)
            mult *= int.Parse(newNum[i].ToString());
        
        return mult;
        
    }
    public int NumMult(float num)
    {
        string newNum = num.ToString().Replace(",", string.Empty);
        int mult = 0;
        for (int i = 0; i < newNum.Length; i++)
        {
            mult *= int.Parse(newNum[i].ToString());
        }
        
        return mult;
        
    }

    public void PrintSum(int num)
    {
        Console.WriteLine(NumSum(num));
    }
    public void PrintMult(int num)
    {
        Console.WriteLine(NumMult(num));
    }
    public void PrintSum(float num)
    {
        Console.WriteLine(NumSum(num));
    }
    public void PrintMult(float num)
    {
        Console.WriteLine(NumMult(num));
    }

    public  bool RemoveOdd( int num, out int deletedNums, out int result, bool oddsNeeded)
    {
        int odds = 0;
        int newNum = 0;
        List<char> list = num.ToString().ToCharArray().ToList();

        for (int i = 0; i < list.Count; i++)
        {
            
            int intNum = int.Parse(list[i].ToString());
            if(intNum % 2 == 0 && oddsNeeded)
            {
                list.Remove(list[i]);
                odds++;
            }
            else if(intNum % 2 != 0 && !oddsNeeded)
            {
                list.Remove(list[i]);
                
            }
        }
        newNum = int.Parse(string.Join("", list.ToArray()));
        deletedNums = odds;
        result = newNum;
        if(odds > 0)
            return true;
        return false;
    }
    
    
}