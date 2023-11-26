namespace DIP;

public interface ILight: IHouseControl
{
    void ChangeIntensity(float value);
}