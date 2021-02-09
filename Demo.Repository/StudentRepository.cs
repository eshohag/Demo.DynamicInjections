using Demo.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Demo.Repository
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(DbContext dbContext) : base(dbContext)
        {
        }
        public List<Student> GetStudents()
        {
            var students = new List<Student>() {
                new Student() { FullName = "Md Shohag Mia", Email = "eshohag@outlook.com" },
                new Student() { FullName = "Shohag", Email = "eshohag@outlook.com" },
                new Student() { FullName = "Shohag Mia", Email = "eshohag@outlook.com" },
                new Student() { FullName = "Md Shohag", Email = "eshohag@outlook.com" }
            };
            return students;
        }
    }
}
