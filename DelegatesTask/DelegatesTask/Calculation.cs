namespace DelegatesTask;
using MathNet.Numerics;

public class Calculation
{
    

    public delegate bool DelRemove(int num, out int oddsAmount, out int result);

    public DelRemove DelRemoveOdd;
    
    public delegate T GenericDelNum<T>(T num);
    public GenericDelNum<float> DelFactorial;
    public GenericDelNum<int> DelFactorialInt;
    public GenericDelNum<float> DelSum;
    public GenericDelNum<int> DelSumInt;
    public GenericDelNum<float> DelMult;
    public GenericDelNum<int> DelMultInt;
    
    
    public delegate void DelPrint<T>(T num);
    
    public DelPrint<float> DelPrintSum;
    public DelPrint<float> DelPrintMult;
    public DelPrint<int> DelPrintSumInt;
    public DelPrint<int> DelPrintMultInt;


    public Calculation()
    {
        DelFactorial = Factorial;
        DelSum = NumSum;
        DelMult = NumMult;
        DelPrintSum = PrintSum;
        DelPrintMult = PrintMult;
        DelRemoveOdd = RemoveOdd;
        


    }
    
    public int Factorial(int num)
    {
        if (num == 1)
            return 1;
        return num * Factorial(num - 1);
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
    public float NumSum(float num)
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
    public float NumMult(float num)
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

    public bool RemoveOdd(int num, out int deletedNums, out int result)
    {
        int odds = 0;
        int newNum = 0;
        List<char> list = num.ToString().ToCharArray().ToList();

        for (int i = 0; i < list.Count; i++)
        {
            int intNum = int.Parse(list[i].ToString());
            if(intNum % 2 == 0)
            {
                list.Remove(list[i]);
                odds++;
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