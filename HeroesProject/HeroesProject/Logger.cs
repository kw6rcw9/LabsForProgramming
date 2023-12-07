using HeroesProject.Abstract;

namespace HeroesProject;

public class Logger : ILogger
{
    public ConsoleColor Color { get; }

    public Logger(ConsoleColor color)
    {
        Color = color;
    }
    public void Log(string message)
    {
        Console.BackgroundColor = Color;
        Console.WriteLine(message);
    }
}