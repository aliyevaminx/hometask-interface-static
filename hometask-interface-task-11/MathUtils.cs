

namespace hometask_interface_task_11
{
    internal static class MathUtils
    {
        public static void CheckPrimeNumber(this int number)
        {
            bool isPrime = true;

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                   isPrime = false;
                }
            }

            if (isPrime)
                Console.WriteLine("Number is prime");
            else
                Console.WriteLine("Number isn't prime");

        }
    }
}
