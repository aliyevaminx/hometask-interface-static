namespace hometask_interface_task_14
{
    internal class TrafficLight
    {
        public enum Color
        {
            Red,
            Yellow,
            Green
        }

        private Color currentColor;

        public Color CurrentColor { get; set; }

        public TrafficLight(Color currentColor)
        {
            CurrentColor = currentColor;
        }

        public void ChangeNextColor()
        {
            switch (CurrentColor)
            {
                case Color.Red:
                    CurrentColor = Color.Yellow;
                    Console.WriteLine(CurrentColor);
                    break;
                case Color.Yellow:
                    CurrentColor = Color.Green;
                    Console.WriteLine(CurrentColor);
                    break;
                case Color.Green:
                    CurrentColor = Color.Red;
                    Console.WriteLine(CurrentColor);
                    break;
                default:
                    Console.WriteLine("Enter right color...");
                    break;
            }
        }
    }
}
