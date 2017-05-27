using System.Web.Mvc;

namespace Yuvia.Web
{
    public class CustomRazorViewEngine : RazorViewEngine
    {
        /*
         * {1} - Location of the Controller
         * {0} - Location of the View Page
         */

        public CustomRazorViewEngine()
        {
            ViewLocationFormats = new string[]
            {
                "~/{1}/Views/{0}.cshtml"
            };

            PartialViewLocationFormats = new string[]
            {
                "~/Shared/Views/{0}.cshtml"
            };
        }
    }
}