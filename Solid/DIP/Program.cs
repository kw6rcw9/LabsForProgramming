using DIP;

SmartHouse smartHouse = new SmartHouse();
Light light = new Light();
Television tv = new Television();
smartHouse.ConnectDevice(light);
smartHouse.ConnectDevice(tv);
light.ChangeIntensity(5);
tv.SwitchChannel("CTC");

smartHouse.Dispose();