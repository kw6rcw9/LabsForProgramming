namespace HeroesProject.Abstract;

public interface IHero
{
     string Name { get;  }
     List<ISkill> SkillsCollection { get; }
    ILogger Logger { get; }
    float Attack(IHero enemy);
    void TakeDamage(IHero enemy, float damage);
}