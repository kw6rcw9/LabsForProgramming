namespace DIP;

public class SmartHouse: IDisposable
{
    private List<IHouseControl> _devices;
    private IHouseObserver _houseObserver;

    public SmartHouse()
    {
        _devices = new List<IHouseControl>();
        _houseObserver = new Observer();
    }

    public void ConnectDevice(IHouseControl device)
    {
        device.Connect(_houseObserver);
        _houseObserver.InvokeEvent();
        device.SwitchOn();
        _devices.Add(device);
       
    }
    
    public void Dispose()
    {
        foreach (var device in _devices)
        {
            device.SwitchOff();
            device.Disconnect(_houseObserver);
            
        }
        _devices.Clear();
        
        
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

    
}