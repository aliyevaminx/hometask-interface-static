static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Celsius to Farenheit: ");
        double farenheit = TemperatureConverter.CelsiusToFahrenheit(Convert.ToDouble(Console.ReadLine()));
        Console.WriteLine("Enter Farenheit to Celsius: ");
        double celsius = TemperatureConverter.FahrenheitToFCelsius(Convert.ToDouble(Console.ReadLine()));

        Console.WriteLine($"Farenheit: {farenheit} \n" +
                          $"Celsius: {celsius}");
    }
}