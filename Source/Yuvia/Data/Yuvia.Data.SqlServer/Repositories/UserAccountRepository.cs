//using System;
//using System.Linq;
//using Yuvia.Core.Data;
//using Yuvia.Data.SqlServer.EntityFramework;
//using Yuvia.Domain.Account.Entities;

//namespace Yuvia.Data.SqlServer.Repositories
//{
//    public class UserAccountRepository : Repository, IRepository<UserAccount>
//    {
//        public UserAccount Get( object id )
//        {
//            var userAccount = this.dataContext.Accounts.Where( account => account.AccountId == (int) id )
//                                                   .Select( account => new UserAccount
//                                                   {
//                                                       AccountId = account.AccountId,
//                                                       Username = account.Username,
//                                                       Password = account.Password,
//                                                       FirstName = account.FirstName,
//                                                       LastName = account.LastName,
//                                                       Email = account.Email,
//                                                       HasSignedLatestTerms = account.HasSignedLatestTerms,
//                                                       SignUpDate = account.SignUpDate
//                                                   } ).FirstOrDefault();

//            return userAccount;
//        }

//        public void Insert( UserAccount userAccount )
//        {
//            this.dataContext.Accounts.Add( new Account
//            {
//                Username = userAccount.Username,
//                Password = userAccount.Password,
//                FirstName = userAccount.FirstName,
//                LastName = userAccount.LastName,
//                Email = userAccount.Email,
//                HasSignedLatestTerms = true,
//                SignUpDate = DateTime.Now
//            } );
            
//            this.dataContext.SaveChanges();
//        }

//        public void Update( UserAccount entity )
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
