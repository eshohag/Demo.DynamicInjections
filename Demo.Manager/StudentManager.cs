using Demo.Entities;
using Demo.Repository;
using System.Collections.Generic;
using System.Linq;

namespace Demo.Manager
{
    public class StudentManager : IStudentManager
    {
        private readonly IStudentRepository _studentRepository;

        public StudentManager(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public List<Student> GetStudents()
        {
            return _studentRepository.GetStudents();
        }
        public List<Student> GetSQLStudents()
        {
            return _studentRepository.All().ToList();
        }
    }
}
