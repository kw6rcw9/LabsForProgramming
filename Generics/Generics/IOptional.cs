public interface IOptional<T>
{
    T Value { get; set; }
    void SetValue(T value);
    T GetValueOrDefault();
    bool Empty { get; }
}