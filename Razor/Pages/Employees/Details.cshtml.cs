using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor.Models;
using Razor.Repository;

namespace Razor.Pages.Employees
{
    public class DetailsModel : PageModel
    {
        private readonly IEmployeeRepository _employeeRepository;

        public DetailsModel(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public Employee Employee { get; set; }
        public IActionResult OnGet(int id)
        {
            Employee = _employeeRepository.GetById(id);

            if(Employee == null)
            {
                return RedirectToPage("/NotFound");
            }

            return Page();
        }
    }
}
