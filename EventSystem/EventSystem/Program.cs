

using EventSystem;

EventManager.Clear();
EventManager.CreateEvent("AttackWaveStart");
EventManager.CreateEvent("AttackWaveEnd");
EventManager.CreateEvent("DateTime");
Player player = new Player();
MyClass myClass = new MyClass();

EventManager.RaiseEvent("DateTime");
Thread.Sleep(1000);

EventManager.RaiseEvent("AttackWaveStart");
EventManager.RaiseEvent("AttackWaveEnd");
Thread.Sleep(1000);
EventManager.RaiseEvent("DateTime");

Thread.Sleep(1000);
EventManager.RaiseEvent("AttackWaveStart");
EventManager.RaiseEvent("AttackWaveEnd");