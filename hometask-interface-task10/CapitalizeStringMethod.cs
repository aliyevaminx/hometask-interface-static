
namespace hometask_interface_task10
{
    internal static class CapitalizeStringMethod
    {
        public static string CapitalizeString(this string element)
        {
          return char.ToUpper(element[0]) + element.Substring(1);
        }
    }
}
