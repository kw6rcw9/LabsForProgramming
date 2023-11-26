namespace DIP;

public class Television: ITv
{
    private bool _isConnected;

    public Television()
    {
        _isConnected = false;
    }
    public void SwitchOn()
    {
        Console.WriteLine("Tv`s on");
    }

    public void SwitchOff()
    {
        Console.WriteLine("Tv`s  off");
    }

    public void Connect(IHouseObserver observable)
    {
        observable.Subscribe(IsConnected);
    }

    public void Disconnect(IHouseObserver observer)
    {
        _isConnected = false;
        observer.UnSubscribe(IsConnected);
    }

    public void SwitchChannel(string newChannel)
    {

        if (!_isConnected)
            throw new Exception("Device is not connected");
        Console.WriteLine($"Switched to {newChannel}");
    }

    private void IsConnected()
    {
        _isConnected = true;
    }

   
}