namespace DIP;

public class Television: ITv, IObserver<string>
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

    public void SwitchChannel(string newChannel)
    {
        if(!_isConnected)
            OnError(new Exception("Device is not connected"));

        Console.WriteLine($"Switched to {newChannel}");
    }

    public void OnCompleted()
    {
        _isConnected = false;
        Console.WriteLine("Device is not connected");
    }

    public void OnError(Exception error)
    {
        throw new Exception(error.Message);
    }

    public void OnNext(string value)
    {
        _isConnected = true;
        Console.WriteLine(value);
    }
}