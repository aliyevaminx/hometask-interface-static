
namespace hometask_interface_task_9
{
    internal static class ReverseStringExtension
    {
        public static void ReverseString(this string element)
        {
            char[] reversedElement = element.ToCharArray();
            int count = 0;

            for (int i = 0; i < reversedElement.Length; i++)
            {
                if (count < reversedElement.Length / 2)
                {
                    char temp = reversedElement[i];
                    reversedElement[i] = reversedElement[reversedElement.Length - 1 - i];
                    reversedElement[reversedElement.Length - 1 - i] = temp;
                    count++;
                }
            }

            element = new string(reversedElement);
            Console.WriteLine(element);
        }
    }
}
