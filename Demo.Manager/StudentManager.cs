using Demo.Entities;
using Demo.Repository;
using System.Collections.Generic;

namespace Demo.Manager
{
    public class StudentManager : IStudentManager
    {
        private readonly IStudentRepository _studentRepository;

        public StudentManager(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public List<Student> GetAllStudents()
        {
            return _studentRepository.GetStudents();
        }
    }
}
