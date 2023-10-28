namespace SecondKT;

public class ObservableIntStack
{
    public event Action<int> OnItemAdded;
    public event Action<int> OnItemRemoved;
    private Stack<int> _stack;
    public int Count => _stack.Count;

    public ObservableIntStack(IEnumerable<int> nums)
    {
        _stack = new Stack<int>();
        foreach (var i in nums)
        {
            _stack.Push(i);
        }
    }

    public void Subscribe(Action<int> subscriber)
    {
        if (subscriber == null)
            throw new ArgumentNullException();
        OnItemAdded += subscriber;
        OnItemRemoved += subscriber;
    }
    public void Unsubscribe(Action<int> subscriber)
    {
        if (subscriber == null)
            throw new ArgumentNullException();
        OnItemAdded -= subscriber;
        OnItemRemoved -= subscriber;
    }

    public void Push(int item)
    {
        _stack.Push(item);
        OnItemAdded?.Invoke(item);
    }

    public void Pop()
    {
        if (_stack == null)
            throw new ArgumentException("Stack is empty");
        OnItemRemoved?.Invoke(_stack.Pop());
    }

    public int Peek() => _stack.Peek();


}