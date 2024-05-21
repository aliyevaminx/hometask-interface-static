using hometask_interface_task_12;

public static class Program
{
    public static void Main(string[] args)
    {
       ProductCatalog productCatalog = new ProductCatalog();

        productCatalog.Add(new Product("Xiaomi X3 Pro", 750, Product.TypeProduct.Electronics));  
        productCatalog.Add(new Product("Samsung S24 Ultra", 3500, Product.TypeProduct.Electronics));
        productCatalog.Add(new Product("IPhone 11", 1500, Product.TypeProduct.Electronics));
        productCatalog.Add(new Product("T-Shirt", 25, Product.TypeProduct.Clothing));
        productCatalog.Add(new Product("Jeans", 55, Product.TypeProduct.Clothing));
        productCatalog.Add(new Product("Jacket", 60, Product.TypeProduct.Clothing));

        productCatalog.GetAll();
        Console.WriteLine();
        Console.WriteLine();
        productCatalog.GetAllProductsByType(Product.TypeProduct.Electronics);
        productCatalog.GetAllProductsByType(Product.TypeProduct.Clothing);
    }
}