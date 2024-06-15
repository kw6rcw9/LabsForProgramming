public class Optional<T> : IOptional<T>
{
    private T _value;
    
    public T Value
    {
        get
        {
            if (Empty)
            {
                throw new IncorrectOptionalAccessException("Value is empty in Optional.");
            }
            return _value;
        }
        set
        {
            _value = value;
        }
    }

    public bool Empty { get; private set; }

    public Optional()
    {
        Empty = true;
    }

    public Optional(T value)
    {
        Value = value;
        Empty = false;
    }

    public void SetValue(T value)
    {
        if (value == null)
        {
            Empty = true;
        }
        else
        {
            Value = value;
            Empty = false;
        }
    }

    public T GetValueOrDefault()
    {
        return Empty ? default : Value;
    }

    public override string ToString()
    {
        return Empty ? "empty" : Value.ToString();
    }
}