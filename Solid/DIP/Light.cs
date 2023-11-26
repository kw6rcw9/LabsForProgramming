using System.Data;

namespace DIP;

public class Light: ILight, IObserver<string>
{
    private bool _isConnected = false;

    public Light()
    {
        _isConnected = false;
    }
    public void SwitchOn()
    {
        Console.WriteLine("Light`s on");
    }

    public void SwitchOff()
    {
        Console.WriteLine("Light`s off");
    }

    public void ChangeIntensity(float value)
    {
        if(_isConnected)
            Console.WriteLine($"The light intensity has changed on {value} value.");
        else
        {
            OnError(new Exception("Device is not connected"));
            
        }
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