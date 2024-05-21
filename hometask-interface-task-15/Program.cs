using hometask_interface_task_15;

public static class Program
{
    public static void Main(string[] args)
    {
        Student student1 = new Student();
        student1.AddGrade(new Grade("Subject1", Grade.StudentDegree.A));
        student1.AddGrade(new Grade("Subject2", Grade.StudentDegree.B));
        student1.GetAllGrades();
        Console.WriteLine();
        Student student2 = new Student();
        student2.AddGrade(new Grade("Subject1", Grade.StudentDegree.D));
        student2.AddGrade(new Grade("Subject2", Grade.StudentDegree.A));
        student2.GetAllGrades();

    }
}