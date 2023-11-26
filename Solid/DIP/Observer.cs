namespace DIP;

public class Observer: IHouseObserver
{
    public event Action? Notify;
    public void Subscribe(Action callback)
    {
        Notify += callback;
    }

    public void UnSubscribe(Action callback)
    {
        Notify -= callback;
    }

    public void InvokeEvent() => Notify?.Invoke();

}