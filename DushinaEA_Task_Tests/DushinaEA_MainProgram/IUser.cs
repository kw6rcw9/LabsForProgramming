namespace DushinaEA_MainProgram;

public interface IUser
{
    ILogger Logger { get; init; }
    double Balance { get; init; }
    string Name { get; init; }
    int Age { get; init; }
    DateTime DateOfRegister { get; init; }
    string? Stocks { get; set; }
    void LogIn();
    void RunApp();
    
}