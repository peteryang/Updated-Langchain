using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsApp
{
    public class CustomWebControl : WebControl
    {
        protected override void RenderContents(HtmlTextWriter writer)
        {
            writer.Write("Hello, this is a testing message.");
        }
    }

    public partial class WebForm1 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CustomWebControl myControl = new CustomWebControl();
            myControl.ID = "MyCustomControl";
            this.form1.Controls.Add(myControl);
        }
    }
}
