namespace EventSystem;

public class Player
{
    public Player()
    {
        EventManager.Subscribe("AttackWaveStart", MessageStart);
        EventManager.Subscribe("AttackWaveEnd", MessageEnd);
        EventManager.Subscribe("DateTime", Date);



    }

    private void MessageStart()
    {
        Console.WriteLine($"Сейчас {DateTime.Now}, я готов к отражению атаки монстров!");
    }

    private void MessageEnd()
    {
        Console.WriteLine("Я успешно отбился от врагов и теперь могу вернуться домой");
        EventManager.UnSubscribe("AttackWaveEnd", MessageEnd);
    }

    private void Date()
    {
       Console.Write($"Текущее время: ");
    }
}