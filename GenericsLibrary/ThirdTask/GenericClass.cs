namespace ThirdTask;

public class GenericClass<T>
{
    public T? Value { get; private set; }

    public GenericClass(T value)
    {
        Value = value;

    }

    public void Reset()
    {
        Value = default;
    }
}