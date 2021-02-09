using Demo.Entities;
using Microsoft.Extensions.DependencyInjection.DynamicInjection;
using System.Collections.Generic;

namespace Demo.Repository
{
    [ScopedService]
    public interface IStudentRepository : IRepository<Student>
    {
        List<Student> GetStudents();
    }
}