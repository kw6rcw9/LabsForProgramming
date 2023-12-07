using HeroesProject.Abstract;

namespace HeroesProject;

public class SwordSkill: ISwordSkill
{
    public string Name { get; }
    public float Damage { get; }
    public float Radius { get; }
    
    public ILogger SkillLogger { get; }
    public float DamageMultiplier { get; }

    public SwordSkill(string name, float damage, float radius, float damageMuliplier, ILogger logger)
    {
        Name = name;
        Damage = damage;
        Radius = radius;
        DamageMultiplier = damageMuliplier;
        SkillLogger = logger;
    }
    public void UseSkill()
    {
        var overallDamage = Damage * DamageMultiplier;
        SkillLogger.Log($"Using {Name}. Base damage: {Damage}, OverallDamage: {overallDamage}, Radius: {Radius}, Damage Multiplier: {DamageMultiplier}");
    }

}