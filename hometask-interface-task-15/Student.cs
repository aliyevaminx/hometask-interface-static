
namespace hometask_interface_task_15
{
    internal class Student
    {
        private Grade[] grades = [];

        public void AddGrade(Grade grade)
        {
            Array.Resize(ref grades, grades.Length + 1);
            grades[grades.Length - 1] = grade;
        }

        public void GetAllGrades()
        {
            foreach (Grade grade in grades)
            {
                Console.WriteLine($"Subject: {grade.Subject} Degree: {grade.Degree}");
            }
        }
    }
}
