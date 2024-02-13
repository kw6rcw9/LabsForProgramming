using System.Globalization;
using System.Reflection.Metadata;

namespace DushinaEA_MainProgram;

public class RegularUser: IUser
{
    public ILogger Logger { get; init; }
    private double _balance;
    private string _name;
    private int _age;
   
    public double Balance
    {
        get => _balance;
        init
        { 
            _balance = value;
            if(_balance < 0)
                throw new ArgumentException("Balance must be above zero");
        }
    }

    public string Name
    {
        get => _name;
        init
        {
            _name = value;
            if (_name.Length < 3)
                throw new ArgumentException("Username must have more than 3 letters");
        }
    }

    public int Age
    {
        get => _age;
        init
        {
            _age = value;
            if (_age < 0)
                throw new ArgumentException("Age must be above zero");
        }
        
    }

    public DateTime DateOfRegister { get; init; }
    public string? Stocks { get; set; }

    public RegularUser(double balance, string name, int age, ILogger logger)
    {
        Logger = logger;
        Balance = balance;
        Name = name;
        Age = age;
        DateOfRegister = GenerateRandomDate();
    }
    public void LogIn()
    {
        Logger.Log($"Hello, {Name}");
    }

    public void RunApp()
    {
        Logger.Log($"Your balance: {Balance.ToString("C", new CultureInfo("en-US"))}");
        if (Stocks != null)
        {
            Logger.Log($"Your promotion is {Stocks}");
        }
    }

    private DateTime GenerateRandomDate()
    {
        Random rnd = new Random();
        return new DateTime(rnd.Next(1990, 2025), rnd.Next(1, 13), rnd.Next(1, 31));
    }
}