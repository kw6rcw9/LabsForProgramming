namespace Events;

public class Counter
{
    public delegate void MyDel();
    public event MyDel? OnCounterChange;
    public int CurrentCounter { get; private set; }

    public void IncreaseCounter(int newNum)
    {
        CurrentCounter += newNum;
        OnCounterChange?.Invoke();
    }
    
    public void DecreaseCounter(int newNum)
    {
        
        CurrentCounter -= newNum;
        if (CurrentCounter < 0)
            throw new Exception("Counter cannot be below or equal zero");
        OnCounterChange?.Invoke();
    }
}