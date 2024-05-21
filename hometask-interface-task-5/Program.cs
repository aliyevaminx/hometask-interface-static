using hometask_interface_task_5;

static class Program
{
    public static void Main(string[] args)
    {
        Car car1 = new("Audi", "RS7", 2019);
        Bus bus1 = new("Scania", "Metropol", 2001, 22);
        Motorcycle motorcycle1 = new("Yamaha", "R25", 2015, 320);

        car1.Start();
        car1.Stop();
        car1.GetDetails();
        Console.WriteLine();
        bus1.Start();
        bus1.Stop();
        bus1.GetDetails();
        Console.WriteLine();
        motorcycle1.Start();
        motorcycle1.Stop();
        motorcycle1.GetDetails();
    }
}