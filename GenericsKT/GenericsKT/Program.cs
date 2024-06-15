using GenericsKT;

TestDictionary<string, int> test = new TestDictionary<string, int>();
test.AddElement("Go", 2);
Console.WriteLine(test.FindElementByKey("Go").Value);
test.RemoveElementByKey("Go");
Console.WriteLine(test.FindElementByKey("Go").Value);