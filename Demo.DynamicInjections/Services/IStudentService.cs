using Demo.DynamicInjections.Models;
using Demo.Entities;
using Microsoft.Extensions.DependencyInjection.DynamicInjection;

namespace Demo.DynamicInjections.Services
{
    [ScopedService]
    public interface IStudentService
    {
        Student GetStudent();
    }
}
