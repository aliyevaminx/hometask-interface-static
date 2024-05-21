using hometask_interface_task_7;

public static class Program
{
    public static void Main(string[] args)
    {
        User user1 = new("user1Name", "user1Surname", User.RegistrationMonthEnum.Iyun, "2020");
        user1.GetDetails();
        User user2 = new("user2Name", "user2Surname", User.RegistrationMonthEnum.Fevral, "2020NFE");
        user2.GetDetails();
        User user3 = new("user3Name", "user3Surname", User.RegistrationMonthEnum.Dekabr, "2020fe");
        user3.GetDetails();
        User user4 = new("user4Name", "user4Surname", User.RegistrationMonthEnum.Mart, "2020feF");
        user4.GetDetails();
        User user5 = new("user5Name", "user5Surname", User.RegistrationMonthEnum.Oktyabr, "2020OFJ");
        user5.GetDetails();
    }
}