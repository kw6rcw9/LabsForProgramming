public class ExtendedOptional<T> : Optional<T>
{
    public event Action<T> OnOptionalFilled;
    public event Action OnOptionalEmptied;

    public ExtendedOptional() : base()
    {
    }

    public ExtendedOptional(T value) : base(value)
    {
        OnOptionalFilled?.Invoke(value);
    }

    public new void SetValue(T value)
    {
        if (Empty && value != null)
        {
            OnOptionalFilled?.Invoke(value);
        }
        else if (!Empty && value == null)
        {
            OnOptionalEmptied?.Invoke();
        }

        base.SetValue(value);
    }
}