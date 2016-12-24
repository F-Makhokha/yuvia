using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yuvia.Core;
using Yuvia.Core.Account;

namespace Yuvia.Services.Account
{
    public class UserAccountService
    {
        private readonly IRepository<UserAccount> _userAccountRepository;
        private readonly IEmailPublisher _emailPublisher;

        public UserAccountService( IRepository<UserAccount> userAccountRepository,
            IEmailPublisher emailPublisher )
        {
            _userAccountRepository = userAccountRepositroy;
            _emailPublisher = emailPublisher;
        }

        public void RegisterAccount( UserAccount userAccount )
        {
            if( userAccount == null )
                return;

            _userAccountRepository.Insert( userAccount );
            _emailPublisher.Send( new Email() );
        }
    }
}
