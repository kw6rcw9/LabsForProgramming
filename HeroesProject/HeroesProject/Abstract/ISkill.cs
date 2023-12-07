namespace HeroesProject.Abstract;

public interface ISkill
{
    string Name { get; }
    float Damage { get; }
    float Radius { get; }
    
    ILogger SkillLogger { get; }

    void UseSkill();
}