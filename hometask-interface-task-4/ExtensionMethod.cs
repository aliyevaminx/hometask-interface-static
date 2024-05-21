
internal static class ExtensionMethod
{
    public static int GetAge(this DateTime birthDate)
    {
        int age = DateTime.Now.Year - birthDate.Year;

        return age;
    } 
}
