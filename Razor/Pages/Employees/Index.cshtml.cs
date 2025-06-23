using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor.Models;
using Razor.Repository;

namespace Razor.Pages.Employees
{
    public class IndexModel : PageModel
    {
        public IEnumerable<Employee> EmployeeList = new List<Employee>();
        private readonly IEmployeeRepository _employeeRepository;

        public IndexModel(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        
        public void OnGet()
        {
            EmployeeList = _employeeRepository.GetAll();
        }
    }
}
