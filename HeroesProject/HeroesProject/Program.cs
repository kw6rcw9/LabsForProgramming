using HeroesProject;
using HeroesProject.Abstract;

IHero swordsHero = HeroFabric.CreateWarrior("SwordsHero", 
    HeroFabric.CreateLogger(ConsoleColor.Black));
IHero swordsFireHero = HeroFabric.CreateFireWarrior("SwordsFireHero", 
    HeroFabric.CreateLogger(ConsoleColor.Red));
IHero swordsFreezeHero = HeroFabric.CreateFreezeWarrior("SwordsFreezeHero", 
    HeroFabric.CreateLogger(ConsoleColor.Blue));

swordsFireHero.TakeDamage(swordsHero, swordsHero.Attack(swordsFireHero));

swordsFreezeHero.TakeDamage(swordsFireHero, swordsFireHero.Attack(swordsFreezeHero));

swordsHero.TakeDamage(swordsFreezeHero, swordsFreezeHero.Attack(swordsHero));
    