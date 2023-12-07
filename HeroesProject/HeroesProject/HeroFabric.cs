using HeroesProject.Abstract;

namespace HeroesProject;

public static class HeroFabric
{
    public static IHero CreateWarrior(string name, ILogger logger)
    {
        var skills = new List<ISkill>()
        {
            new SwordSkill("Sword", 10, 1, 2, logger),

        };
        
        return new Hero(name, skills, logger);
    }
    public static IHero CreateFireWarrior(string name, ILogger logger)
    {
        var skills = new List<ISkill>()
        {
            new SwordSkill("Sword", 10, 1, 3, logger),
            new FireSkill("Fire", 30, 4, logger, 5)

        };
        
        return new Hero(name, skills, logger);
    }
    public static IHero CreateFreezeWarrior(string name, ILogger logger)
    {
        var skills = new List<ISkill>()
        {
            new SwordSkill("Sword", 10, 1, 4, logger),
            new FreezeSkill("Freeze", 20, 2, IceColor.Blue, 5, logger)

        };
        
        return new Hero(name, skills, logger);
    }

    public static ILogger CreateLogger(ConsoleColor color)
    {
        return new Logger(color);
    }
}