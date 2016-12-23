using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Yuvia.Core.Account;

namespace Yuvia.Core.Test.Account
{
    public class UserAccountTests
    {
        [Fact]
        public void Initiate()
        {
            // Arrange
            var userAccount = new UserAccount
            {
                Username = "Sampleuser",
                SignUpDate = DateTime.Now
            };


            // Act

            // Assert
            Assert.False(userAccount.IsValid);
        }
    }
}
