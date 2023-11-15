using InterfaceImplement;

IVehiculo car = new Car(0);
Console.WriteLine("Enter amount to refuel");
int newAmount = int.Parse(Console.ReadLine());
if(car.Refuel(newAmount))
    car.Drive();
    