using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Http;

namespace Yuvia.Web
{
    public class Global : HttpApplication
    {
        private void Application_Start( object sender, EventArgs e )
        {
            /* Configure the Custom Razor View Engine */
            // ViewEngines.Engines.Clear();
            // ViewEngines.Engines.Add( new CustomRazorViewEngine() );

            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure( WebApiConfig.Register );
            RouteConfig.RegisterRoutes( RouteTable.Routes );
        }
    }
}