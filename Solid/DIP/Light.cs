using System.Data;

namespace DIP;

public class Light: ILight
{
    private bool _isConnected = false;

    public Light()
    {
        _isConnected = false;
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

    public void SwitchOn()
    {
        Console.WriteLine("Light`s on");
    }

    public void SwitchOff()
    {
        Console.WriteLine("Light`s off");
    }

    private void IsConnected()
    {
        _isConnected = true;
    }

    public void ChangeIntensity(float value)
    {
        if (!_isConnected)
            throw new Exception("Device is not connected");
        Console.WriteLine($"The light intensity has changed on {value} value.");
       
    }

   

   
}