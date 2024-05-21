
using static hometask_interface_task_12.Product;

namespace hometask_interface_task_12
{
    internal class ProductCatalog
    {
        private Product[] products = [];

        public void Add(Product product)
        {
            Array.Resize(ref products, products.Length + 1);
            products[products.Length - 1] = product;
        }

        public void GetAll()
        {
            foreach (Product product in products)
            {
                Console.WriteLine($"Name: {product.Name} Price: {product.Price} Type: {product.Type}");
            }
        }

        public void GetAllProductsByType(TypeProduct type)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].Type == type)
                {

                    if (products[i].Type == type)
                    {
                        Console.WriteLine($"{products[i].Name} {products[i].Price} {products[i].Type}");
                    }
                }
            }
        }

    }
}
