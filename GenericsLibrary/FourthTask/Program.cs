// See https://aka.ms/new-console-template for more information

using ForthTask;

Circle<int> circle1 = new Circle<int>(5);
Circle<string> circle2 = new Circle<string>("7");
Circle<double> circle3 = new Circle<double>(3.2);
Circle<float> circle4 = new Circle<float>(2.4f);
circle1.SetRadius("7");
Console.WriteLine($"Radius: {circle1.Radius}; Square: {circle1.Square}");
circle2.SetRadius(5);
Console.WriteLine($"Radius: {circle2.Radius}; Square: {circle2.Square}");
circle1.SetRadius(2.4f);
Console.WriteLine($"Radius: {circle3.Radius}; Square: {circle3.Square}");
circle2.SetRadius(3);
Console.WriteLine($"Radius: {circle4.Radius}; Square: {circle4.Square}");


