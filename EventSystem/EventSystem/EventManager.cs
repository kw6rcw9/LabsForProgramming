namespace EventSystem;

public static class EventManager
{
    private static Dictionary<string, Action?> _eventsList = new Dictionary<string, Action?>();
   



    public static void CreateEvent(string eventName)
    {
        if (_eventsList.ContainsKey(eventName))
            Exception("Событие с таким именем уже существует");
            
        _eventsList.Add(eventName, null);
        

    }

    public static void RemoveEvent(string eventName)
    {
        if (!_eventsList.ContainsKey(eventName))
            Exception("События с таким именем не существует");
        
        _eventsList.Remove(eventName);
    }

    public static void RaiseEvent(string eventName)
    {
        if (!_eventsList.ContainsKey(eventName))
            Exception("События с таким именем не существует");
        if(_eventsList[eventName] == null)
            Exception("У события нет подписчиков");
        
        _eventsList[eventName]?.Invoke();
        
    }

    public static void Clear()
    {
        _eventsList.Clear();
    }
    
    public static void Subscribe(string eventName, Action callBack)
    {
        if (!_eventsList.ContainsKey(eventName))
            Exception("События с таким именем не существует");
        if (_eventsList[eventName] == null)
            _eventsList[eventName] = callBack;
        else
        {
            _eventsList[eventName] += callBack;
        }
            

    }
    

    public static void UnSubscribe(string eventName, Action callback)
    {
        if (!_eventsList.ContainsKey(eventName))
            Exception("События с таким именем не существует");
        _eventsList[eventName] -= callback;

    }

    private static void Exception(string message) =>
        throw new ArgumentException(message);
    
        
    
    
}