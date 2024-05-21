using hometask_interface_task_14;

public static class Program
{
    public static void Main(string[] args)
    {
        TrafficLight trafficLight = new TrafficLight(TrafficLight.Color.Yellow);
        trafficLight.ChangeNextColor();
        trafficLight.ChangeNextColor();
        trafficLight.ChangeNextColor();
        trafficLight.ChangeNextColor();
    }
}