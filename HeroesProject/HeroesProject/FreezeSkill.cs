using HeroesProject.Abstract;

namespace HeroesProject;

public class FreezeSkill: IFreezeSkill
{
    public string Name { get; }
    public float Damage { get; }
    public float Radius { get; }
    public ILogger SkillLogger { get; }
    public IceColor Color { get; }
    public float TimeOfReloading { get; }

    public FreezeSkill(string name, float damage, float radius, IceColor iceColor, float reloadTime, ILogger logger)
    {
        Name = name;
        Radius = radius;
        Damage = damage;
        SkillLogger = logger;
        Color = iceColor;
        TimeOfReloading = reloadTime;
    }
    
    public void UseSkill()
    {
        SkillLogger.Log($"Using {Name}. Damage: {Damage}, Radius: {Radius}, ReloadTime: {TimeOfReloading}, IceColor: {Color.ToString()}");
       
    }
}