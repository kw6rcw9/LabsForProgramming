using SecondTask;

List<IProduct> products = new List<IProduct>()
{
  new FoodProduct("Apple", 2, "Tasty"),  
  new ClothingProduct("Jeans", 20, "Slim"),
  new ApplianceProduct("Phone", 300,"Iphone", 1000)
  
};

foreach (IProduct product in products)
{
  product.GetInfo();
  Console.WriteLine();
}