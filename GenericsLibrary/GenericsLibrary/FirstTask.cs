namespace GenericsLibrary;

public static class FirstTask
{
    

    public static float Sum(List<object> list)
    {
        float sum = 0;
        foreach (var i in list)
            sum += Convert.ToSingle(i);

        

        return sum;
    }
    
}