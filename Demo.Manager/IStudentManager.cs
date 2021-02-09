using Demo.Entities;
using Microsoft.Extensions.DependencyInjection.DynamicInjection;
using System.Collections.Generic;

namespace Demo.Manager
{
    [ScopedService]
    public interface IStudentManager
    {
        List<Student> GetStudents();
        List<Student> GetSQLStudents();
    }
}
