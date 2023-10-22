namespace Events;

public class Counter
{
    public delegate void MyDel();
    public event MyDel? OnCounterChange;
    public event Func<int> OverFlow;
    public int CurrentCounter { get; private set; }
    private const int _limit = 100;

    public void IncreaseCounter(int newNum)
    {
        CurrentCounter += newNum;
        if(CurrentCounter >= _limit)
             CurrentCounter = OverFlow.Invoke();
        
        OnCounterChange?.Invoke();
    }
    
    public void DecreaseCounter(int newNum)
    {
        
        CurrentCounter -= newNum;
        if (CurrentCounter <= 0)
            throw new Exception("Counter cannot be below or equal zero");
        OnCounterChange?.Invoke();
    }
}