namespace EventSystem;

public class MyClass
{
    public MyClass()
    {
        EventManager.Subscribe("AttackWaveStart", delegate {  });
        EventManager.Subscribe("AttackWaveEnd", delegate {  });
        EventManager.Subscribe("DateTime", () => Console.WriteLine(DateTime.Now));
        
    }
}