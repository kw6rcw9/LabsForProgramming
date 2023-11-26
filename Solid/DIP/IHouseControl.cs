namespace DIP;

public interface IHouseControl
{

   void SwitchOn();
   void SwitchOff();

   void Connect(IHouseObserver observer);
   void Disconnect(IHouseObserver observer);
}