namespace DIP;

public interface IHouseObserver
{
    void Subscribe(Action callback);
    void UnSubscribe(Action callback);
    void InvokeEvent();
}