
namespace hometask_interface_task_6
{
    internal static class ExtensionMethod
    {
        public static bool CheckPolindromString(this string word)
        {
            string reversedString = new String(word.Reverse().ToArray());

            if (reversedString == word)
            {
                return true;
            }
            return false;
        }
    }
}
