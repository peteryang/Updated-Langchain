using Microsoft.AspNetCore.Razor.TagHelpers;
        
        namespace AspNetCoreApp
        {
            public class CustomWebControl : TagHelper
            {
                public override void Process(TagHelperContext context, TagHelperOutput output)
                {
                    output.Content.SetHtmlContent("Hello, this is a custom WebControl for ASP.NET Core Razor Pages.");
                }
            }
        }