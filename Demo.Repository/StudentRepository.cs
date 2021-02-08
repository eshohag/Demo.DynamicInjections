using Demo.Entities;
using System.Collections.Generic;

namespace Demo.Repository
{
    public class StudentRepository : IStudentRepository
    {
        public List<Student> GetStudents()
        {
            var students = new List<Student>();
            students.Add(new Student() { FullName = "Md Shohag Mia", Email = "eshohag@outlook.com" });
            return students;
        }
    }
}
