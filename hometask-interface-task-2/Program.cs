using hometask_interface_task_2;

static class Program
{
    public static void Main(string[] args)
    {
        int monthNumber = Convert.ToInt32(Console.ReadLine());
        Months month = (Months) monthNumber;


        switch (month)
        {
            case Months.yanvar:
                Console.WriteLine("Winter");
                break;
            case Months.fevral:
                Console.WriteLine("Winter");
                break;
            case Months.mart:
                Console.WriteLine("Yaz");
                break;
            case Months.aprel:
                Console.WriteLine("Yaz");
                break;
            case Months.may:
                Console.WriteLine("Yaz");
                break;
            case Months.iyun:
                Console.WriteLine("Yay");
                break;
            case Months.iyul:
                Console.WriteLine("Yay");
                break;
            case Months.avqust:
                Console.WriteLine("Yay");
                break;
            case Months.sentyabr:
                Console.WriteLine("Payiz");
                break;
            case Months.oktyabr:
                Console.WriteLine("Payiz");
                break;
            case Months.noyabr:
                Console.WriteLine("Payiz");
                break;
            case Months.dekabr:
                Console.WriteLine("Winter");
                break;
            default:
                Console.WriteLine("Invalid month");
                break;
        }
    }
}