using Demo.DynamicInjections.Services;
using Demo.Manager;
using Microsoft.AspNetCore.Mvc;

namespace Demo.DynamicInjections.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;
        private readonly IDepartmentService _departmentService;
        private readonly IStudentManager _studentManager;

        public StudentController(IStudentService studentService, IDepartmentService departmentService, IStudentManager studentManager)
        {
            _studentService = studentService;
            _departmentService = departmentService;
            _studentManager = studentManager;
        }

        public IActionResult Index()
        {
            var student = _studentService.GetStudent();
            var department = _departmentService.DeptName();
            var allStudents = _studentManager.GetAllStudents();
            return View();
        }
    }
}
