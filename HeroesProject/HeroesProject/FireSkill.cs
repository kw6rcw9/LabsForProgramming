using HeroesProject.Abstract;

namespace HeroesProject;

public class FireSkill: IFireSkill
{
    public string Name { get; }
    public float Damage { get; }
    public float Radius { get; }
    public ILogger SkillLogger { get; }
    public float TimeOfBurning { get; }


    public FireSkill(string name, float damage, float radius, ILogger logger, float timeOfBurning)
    {
        Name = name;
        Damage = damage;
        Radius = radius;
        SkillLogger = logger;
        TimeOfBurning = timeOfBurning;
    }
    public void UseSkill()
    {
        SkillLogger.Log($"Using {Name}. Base damage: {Damage}, Radius: {Radius}, FireTime: {TimeOfBurning}");
       
    }
    
}