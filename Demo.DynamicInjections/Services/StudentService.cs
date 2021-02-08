using Demo.Entities;

namespace Demo.DynamicInjections.Services
{
    public class StudentService : IStudentService, IDepartmentService
    {
        public Student GetStudent()
        {
            return new Student() { FullName = "Md Shohag Mia", Email = "eshohag@outlook.com" };
        }
        public string DeptName()
        {
            return "CSE";
        }
    }
}
