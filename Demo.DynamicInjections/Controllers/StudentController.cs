using Demo.Manager;
using Demo.Services;
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
            var studentService = _studentService.GetStudent();
            var deptNameDepartmentService = _departmentService.DeptName();
            var studentsRaw = _studentManager.GetStudents();
            var studentsSQLDatabase = _studentManager.GetSQLStudents();

            return View();
        }
    }
}
