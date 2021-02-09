using Microsoft.Extensions.DependencyInjection.DynamicInjection;

namespace Demo.Services
{
    [ScopedService]
    public interface IDepartmentService
    {
        string DeptName();
    }
}
