namespace HeroesProject.Abstract;

public interface ILogger
{
    ConsoleColor Color { get; }
    void Log(string message);
}
