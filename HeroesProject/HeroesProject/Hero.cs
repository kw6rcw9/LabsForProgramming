using HeroesProject.Abstract;

namespace HeroesProject;

public class Hero: IHero
{
    public string Name { get; }
    public List<ISkill> SkillsCollection { get; }
    public ILogger Logger { get; }

    public Hero(string name, List<ISkill> skills, ILogger logger)
    {
        Name = name;
        SkillsCollection = skills;
        Logger = logger;
    }

    public float Attack(IHero enemy)
    {
        float totalDamage = 0;
        Logger.Log($"{Name} attacks {enemy.Name}");
        foreach (var skill in SkillsCollection)
        {
            skill.UseSkill();
            if (skill is SwordSkill)
            {
                var swordSkill = (SwordSkill)skill;
                totalDamage += swordSkill.Damage * swordSkill.DamageMultiplier;
            }
            else
            {
                totalDamage += skill.Damage;
                
            }
            
        }

        return totalDamage;
    }

    public void TakeDamage(IHero enemy, float damage)
    {
        Logger.Log($"{Name} received {damage} damage from {enemy.Name}");
    }
}