using LSP;

IFigure figure;
figure = new Triangle(3,4,5);
Console.WriteLine(figure.GetArea());
figure = new Rectangle(10,20);
Console.WriteLine(figure.GetArea());