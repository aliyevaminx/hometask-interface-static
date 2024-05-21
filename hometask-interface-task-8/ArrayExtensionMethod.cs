
namespace hometask_interface_task_8
{
    internal static class ArrayExtensionMethod
    {
        public static int GetAverageOfArray(this int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i]; 
            }

            return sum / array.Length;
        }
    }
}
