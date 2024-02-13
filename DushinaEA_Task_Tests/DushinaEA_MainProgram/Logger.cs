namespace DushinaEA_MainProgram;

public class Logger: ILogger
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}