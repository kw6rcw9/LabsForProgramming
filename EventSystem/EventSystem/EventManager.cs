namespace EventSystem;

public static class EventManager
{
    private static Dictionary<string, Action> _eventsList;
   
    

    public static void CreateEvent(string eventName)
    {
    }
    public static void RemoveEvent(string eventName){}
    public static void RaiseEvent(string eventName){}
    public static void Clear(){}

// Методы подписки и отписки

// Здесь на месте Action может быть также и Action<T>,
// где T - параметр любого типа 
    public static void Subscribe(string eventName, Action callBack){}
    public static void UnSubscribe(string eventName, Action callback){}


    
}