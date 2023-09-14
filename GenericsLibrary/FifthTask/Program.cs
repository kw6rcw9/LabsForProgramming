using System.Numerics;
using FifthTask;
Rectangle<int, string> rectangle1 = new Rectangle<int, string>(2,"4", new Vector2(0,0));
Rectangle<double, float> rectangle2 = new Rectangle<double, float>(3.3,2.5f, new Vector2(1.5f,2.5f));
Rectangle<float, string> rectangle3 = new Rectangle<float, string>(4.2f,"3", new Vector2(-2,3));
Console.WriteLine($"MinPoint: {rectangle1.MinPoint.X}, {rectangle1.MinPoint.Y} MaxPoint: {rectangle1.MaxPoint.X}, {rectangle1.MaxPoint.Y}");
Console.WriteLine($"MinPoint: {rectangle2.MinPoint.X}, {rectangle2.MinPoint.Y} MaxPoint: {rectangle2.MaxPoint.X}, {rectangle2.MaxPoint.Y}");
Console.WriteLine($"MinPoint: {rectangle3.MinPoint.X}, {rectangle3.MinPoint.Y} MaxPoint: {rectangle3.MaxPoint.X}, {rectangle3.MaxPoint.Y}");