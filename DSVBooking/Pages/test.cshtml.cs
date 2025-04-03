using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DSVBooking.Pages
{
    public class testModel : PageModel
    {
        public void OnGet()
        {
        }

        public IActionResult OnPostLoad(string upassende)
        {
            Debug.WriteLine(upassende);
            return Page();
        }
    }
}
