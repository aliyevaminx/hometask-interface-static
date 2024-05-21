
namespace hometask_interface_task_15
{
    internal class Grade
    {
        public enum StudentDegree
        {
            A,
            B,
            C,
            D
        }

        private string subject;
        private StudentDegree degree;

        public string Subject { get; set; }
        public StudentDegree Degree { get; set; }

        public Grade(string subject, StudentDegree degree)
        {
            Subject = subject;
            Degree = degree;
        }
    }
}
