using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Yuvia.Core;
using Yuvia.Core.Account;
using Yuvia.Services.Account;

namespace Yuvia.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserAccountService _userAccountService;

        public AccountController( IRepository<UserAccount> userAccountRepository, IEmailPublisher emailPublisher )
        {
            _userAccountService = new UserAccountService( userAccountRepository, emailPublisher );
        }

        [HttpGet]
        public ViewResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register( UserAccount userAccount )
        {
            IList<ValidationResult> validationResults = new List<ValidationResult>();
            ValidationContext validationContext = new ValidationContext( userAccount );

            if( Validator.TryValidateObject( userAccount, validationContext, validationResults ) )
            {
                _userAccountService.RegisterAccount( userAccount );

                return RedirectToAction( "Dashboard" );
            }

            return View();
        }
    }
}