using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCoreApp.Pages
{
    public class CustomWebControlPageModel : PageModel
    {
        public string Message { get; private set; } = "Hello, this is a custom WebControl for .NET 8+ using Razor Pages.";

        public void OnGet()
        {
            // Logic to be executed when the page is accessed
        }
    }
}