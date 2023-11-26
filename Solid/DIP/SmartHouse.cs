namespace DIP;

public class SmartHouse: IDisposable, IObservable<string>
{
    private List<IHouseControl> _devices;
    private List<IObserver<string>> _observers;

    public SmartHouse()
    {
        _devices = new List<IHouseControl>();
        _observers = new List<IObserver<string>>();
    }

    public void ConnectDevice(IHouseControl device)
    {
        Subscribe((IObserver<string>)device);
        device.SwitchOn();
        _devices.Add(device);
        _observers.Add((IObserver<string>)device);
    }
    
    public void Dispose()
    {
        foreach (var device in _devices)
        {
            device.SwitchOff();
            
        }

        foreach (var observer in _observers)
        {
            observer.OnCompleted();
            
        }
        _devices.Clear();
        _observers.Clear();
        
    }

    public void TurnOffDevice(IHouseControl device)
    {
        if (!_devices.Contains(device))
            throw new NullReferenceException("Not such device in House Control");
        device.SwitchOff();
    }
    public void TurnOnDevice(IHouseControl device)
    {
        if (!_devices.Contains(device))
            throw new NullReferenceException("Not such device in House Control");
        device.SwitchOn();
    }

    public IDisposable Subscribe(IObserver<string> observer)
    {
        observer.OnNext("Device`s connected");
        return this;
    }
}