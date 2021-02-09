using Demo.Entities;
using Microsoft.Extensions.DependencyInjection.DynamicInjection;

namespace Demo.Services
{
    [ScopedService]
    public interface IStudentService
    {
        Student GetStudent();
    }
}
