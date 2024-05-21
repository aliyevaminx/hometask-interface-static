
namespace hometask_interface_task_7
{
    internal class User
    {
        private string pin;

        public string Name { get; set; }
        public string Surname { get; set; }
        public RegistrationMonthEnum RegistrationMonth { get; set; }

        public string Pin {
            get => pin;
            set
            {
                if (value.CheckPin()) { pin = value; }
                else { Console.WriteLine($"PIN must be 7 characters long and uppercase - User: {Name}"); }
            }
        
        }

        public enum RegistrationMonthEnum : int
        {
            Yanvar,
            Fevral,
            Mart,
            Aprel,
            May,
            Iyun,
            Iyul,
            Avqust,
            Sentyabr,
            Oktyabr,
            Noyabr,
            Dekabr
        }

        public User(string name, string surname, RegistrationMonthEnum registrationMonth, string pin)
        {
            Name = name;
            Surname = surname;
            RegistrationMonth = registrationMonth;
            Pin = pin;
        }

        public void GetDetails()
        {
            Console.WriteLine($"Name: {Name} Surname: {Surname} Month: {RegistrationMonth} PIN: {Pin} ");
        }
    }
}
