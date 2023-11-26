// Создайте класс "Круг" с методами "Вычислить площадь"
// и "Вычислить длину окружности". Убедитесь, что
// класс соответствует принципу SRP (Single Responsibility Principle).

using SRP;

Shape circle = new Circle(10);
Shape rec = new Rectangle(10, 20);
Printer print = new Printer();
print.PrintArea(circle);
print.PrintCircleLength((Circle)circle);
print.PrintArea(rec);


