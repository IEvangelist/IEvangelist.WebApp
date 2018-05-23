using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IEvangelist.WebApp.Pages
{
    public class ContactModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet() => Message = nameof(IEvangelist);
    }
}