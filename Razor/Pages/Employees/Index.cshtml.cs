using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Razor.Pages.Employees
{
    public class IndexModel : PageModel
    {
        public string Message { get; set; }
        public void OnGet()
        {
            Message = "Merhaba";
        }
    }
}
