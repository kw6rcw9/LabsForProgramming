using classLibrary;

List<Property> list = new List<Property>()
{
    new CountryHouse(350f, 5000000f),
    new CountryHouse(250f, 4000000f),
    new Boat(2666f, 400000f),
    new Boat(3000f, 480000f),
    new Car(2500f, 800000f),
    new Car(2000f, 600000f),
    new Car(3000f, 1000000f),
    new Appartment(60f, 15000000f),
    new Appartment(30f, 8000000f),
    new Appartment(100f, 20000000f)

};

foreach (Property property in list)
{
    Console.WriteLine(property.ToString());
}

