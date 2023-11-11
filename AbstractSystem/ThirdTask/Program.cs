using ThirdTask;

List<Product> products = new List<Product>()
{
   new Clothes("Black", 20.49f, "Very comfortable jeans", 10 ),
   new Electronic(1000f,45f, "New powerfull phone", 30 ),
   new Food("Fruits", 2, "Juicy apple", 40)
};

foreach (Product product in products)
{
    product.GetDescription();
    Console.WriteLine();
}