namespace DIP;

public interface ITv: IHouseControl
{
    void SwitchChannel(string newChannel);
}