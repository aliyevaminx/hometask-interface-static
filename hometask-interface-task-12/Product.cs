
namespace hometask_interface_task_12
{
    internal class Product
    {
        public enum TypeProduct
        {
            Electronics,
            Clothing,
            Books,
            Groceries
        }

        private string name;
        private int price;
        private TypeProduct type;

        public string Name { get; set; }
        public int Price { get; set; }
        public TypeProduct Type { get; set; }

        public Product(string name, int price, TypeProduct type)
        {
            Name = name;
            Price = price;
            Type = type;
        }


    }
}
