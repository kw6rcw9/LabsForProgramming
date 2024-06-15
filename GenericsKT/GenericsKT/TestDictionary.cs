using System.Collections;

namespace GenericsKT;

public class TestDictionary<T1, T2> : IEnumerable<TestKeyValuePairs<T1, T2>>
{
    private List<TestKeyValuePairs<T1, T2>> elements = new();

    public void AddElement(T1 key, T2 value)
    {
        if (elements.Any(e => e.Key.Equals(key)))
        {
            throw new Exception("Element with this key already exists.");
        }

        elements.Add(new TestKeyValuePairs<T1, T2>(key, value));
    }

    public void RemoveElementByKey(T1 key)
    {
        TestKeyValuePairs<T1, T2> element = elements.FirstOrDefault(e => e.Key.Equals(key));
        if (element != null)
        {
            elements.Remove(element);
        }
    }

    public void RemoveElementByValue(T2 value)
    {
        TestKeyValuePairs<T1, T2> element = elements.FirstOrDefault(e => e.Value.Equals(value));
        if (element != null)
        {
            elements.Remove(element);
        }
    }

    public TestKeyValuePairs<T1, T2> FindElementByKey(T1 key)
    {
        TestKeyValuePairs<T1, T2> element = elements.FirstOrDefault(e => e.Key.Equals(key));
        if (element != null)
        {
            return element;
        }
        throw new ElemetNotFoundException("Element with this key not found.");
    }

    public TestKeyValuePairs<T1, T2> FindElementByValue(T2 value)
    {
        TestKeyValuePairs<T1, T2> element = elements.FirstOrDefault(e => e.Value.Equals(value));
        if (element != null)
        {
            return element;
        }
        throw new ElemetNotFoundException("Element with this value not found.");
    }

    public IEnumerator<TestKeyValuePairs<T1, T2>> GetEnumerator()
    {
        return elements.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}