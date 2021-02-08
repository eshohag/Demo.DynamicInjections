using Microsoft.Extensions.DependencyInjection.DynamicInjection;

namespace Demo.DynamicInjections.Services
{
    [ScopedService]
    public interface IDepartmentService
    {
        string DeptName();
    }
}
