using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebClient.Pages
{
    [Authorize]
    public class SignInModel : PageModel
    {
        public IActionResult OnGet()
        {
           
            return RedirectToPage("/Index");
        }
    }
}
