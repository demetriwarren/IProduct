namespace IProduct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*3 classes of products all need to implement iproduct interface 
            define name and price properties, 
            create 2 instances of each class, load into a colleciton type (list), iterate through and print the name and price
            */


            List<IProduct> products = new List<IProduct>();
            products.Add(new IPhone { ProductName = "IPhone 12", Color = "Black", Memory = "32Gb", Price = 1000 });
            products.Add(new IPhone { ProductName = "IPhone 13", Color = "Metallic Silver", Price = 1100, Memory = "128Gb" });
            products.Add(new Macbook { ProductName = "MacBook Pro", Color = "Space Blue", Price = 2900, Memory = "2TB", });
            products.Add(new Macbook { ProductName = "MacBook Air", Color = "Gunmetal Grey", Price = 2400, Memory = "1TB"});
            products.Add(new IPad { ProductName = "IPad 6", Color = "Black", Price = 1600, Memory = "216GB" });
            products.Add(new IPad { ProductName = "IPad 6", Color = "Grey", Price = 2200, Memory = "500GB" });

            foreach (var product in products)
            {
                Console.WriteLine($"The {product.Color} {product.ProductName} is {product.Price:C} with {product.Memory} of Storage Space");
            }

        }
    }
}
