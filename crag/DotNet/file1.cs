using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebFormsApp
{
    public class CustomWebControl : Microsoft.AspNetCore.Mvc.ViewComponents.ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return Content("Hello, this is a custom WebControl for ASP.NET Core Razor Pages.");
        }
    }

    public partial class WebForm1 : PageModel
    {
        public void OnGet()
        {
            CustomWebControl myControl = new CustomWebControl();
            myControl.ViewContext = this.ViewContext;
            this.Response.BodyWriter.Write("Hello, this is a custom WebControl for ASP.NET Core Razor Pages.");
        }
    }
}