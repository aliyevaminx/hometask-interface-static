namespace hometask_interface_static
{
    internal class Calculator : ICalculator
    {
        public double Sum(double x, double y )
        {
            return x + y;
        }  
        public double Subtract(double x, double y )
        {
            return x - y;
        }
        public double Divide(double x, double y)
        {
            return x / y;
        }
        public double Multiply(double x, double y)
        {
            return x * y;
        }

    }
}
