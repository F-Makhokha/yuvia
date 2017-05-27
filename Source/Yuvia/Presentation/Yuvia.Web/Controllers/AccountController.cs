using System.Web.Mvc;
using Yuvia.Core.Data;
using Yuvia.Core.Email;
using Yuvia.Data.SqlServer.Repositories;
using Yuvia.Domain.Account.Entities;
using Yuvia.Domain.Account.Repositories;
using Yuvia.Domain.Account.Services;
using Yuvia.Web.Models;

namespace Yuvia.Web.Controllers
{
    public class AccountController : Controller
    {
        //private readonly UserAccountService _userAccountService;

        public AccountController()
            : base()
        {
            //_userAccountService = new UserAccountService( new UserAccountRepository() );
        }

        public AccountController( IUserAccountRepository userAccountRepository, IEmailPublisher emailPublisher )
            : base()
        {
            //_userAccountService = new UserAccountService( userAccountRepository, emailPublisher );
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register( RegistrationViewModel registrationViewModel )
        {
            //IList<ValidationResult> validationResults = new List<ValidationResult>();
            //ValidationContext validationContext = new ValidationContext( registrationViewModel );
            //var state = ModelState;

            //if( Validator.TryValidateObject( registrationViewModel, validationContext, validationResults ) )
            //{
            //    //_userAccountService.RegisterAccount( userAccount );

            //    //return RedirectToAction( "Dashboard" );
            //    return RedirectToAction( "Authenticate" );
            //}

            //if( ModelState.IsValid )
            //{
            //    var userAccount = new UserAccount
            //    {
            //        Username = registrationViewModel.Username,
            //        Password = registrationViewModel.Password,
            //        Email = registrationViewModel.Email
            //    };

            //    _userAccountService.RegisterAccount( userAccount );
            //}

            return View();
        }

        [HttpGet]
        public ActionResult Authenticate()
        {
            return View();
        }
    }
}