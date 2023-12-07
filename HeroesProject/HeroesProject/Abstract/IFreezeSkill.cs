namespace HeroesProject.Abstract;

public interface IFreezeSkill: ISkill
{
    IceColor Color  { get; }
    float TimeOfReloading { get; }
}