using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCoreApp.Pages
{
    public class CustomWebControlPageModel : PageModel
    {
        public string Message { get; private set; } = "Hello, this is a custom WebControl for .NET 8+.";

        public void OnGet()
        {
            Message = "Hello, this is a custom WebControl for .NET 8+.";
        }
    }
}