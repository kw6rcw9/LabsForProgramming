

List<object> list = new List<object>{ 10, 5.5f, 15, 4.2f, 10.5f};
Console.WriteLine(Sum(list));

static float Sum(List<object> list)
{
    float sum = 0;
    foreach (var i in list)
        sum += Convert.ToSingle(i);

        

    return sum;
}