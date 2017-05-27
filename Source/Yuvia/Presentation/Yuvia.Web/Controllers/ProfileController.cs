using System.Web.Mvc;

namespace Yuvia.Web.Controllers
{
    /// <summary>
    /// Profile Interaction and Maintenance Code
    /// </summary>
    [RoutePrefix( "Profile" )]
    public class ProfileController : Controller
    {

        public ProfileController()
        {

        }

        /// <summary>
        /// Gets the current user's profile page.
        /// </summary>
        /// <returns></returns>
        //[Route("")]
        //public ActionResult Index()
        //{
        //    //ProfileModel model = _getProfileQuery.Execute(username);
        //    //return View(model);
        //    return View();
        //}

        [Route( "{username}" )]
        public ActionResult Index( string username )
        {
            return View( "Profile" );
        }
    }
}