
namespace hometask_interface_task_7
{
    internal static class StringExtensionMethod
    {
        public static bool CheckPin(this string pin)
        {
            if (pin.Length == 7 && pin.ToUpper() == pin)
                return true;
            return false;
        }
    }
}
