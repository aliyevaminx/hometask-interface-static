using hometask_interface_static;

static class Program
{
    public static void Main(string[] args)
    {

        Calculator calculator = new Calculator();
        double x;
        double y;

        do
        {
            Console.WriteLine("First number: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Second number: ");
            y = Convert.ToDouble(Console.ReadLine());

        } while (x == 0 || y == 0);

        Console.WriteLine("Choose operation +, -, /, *");
        string operation = Console.ReadLine();
      

        switch (operation)
        {
            case "+":
                Console.WriteLine($"Result: {calculator.Sum(x, y)}");
                break;
            case "-":
                Console.WriteLine($"Result: {calculator.Subtract(x, y)}");
                break;
            case "/":
                Console.WriteLine($"Result: {calculator.Divide(x, y)}");
                break;
            case "*":
                Console.WriteLine($"Result: {calculator.Multiply(x, y)}");
                break;
            default:
                Console.WriteLine("Enter right value...");
                break;
        }

    }
}