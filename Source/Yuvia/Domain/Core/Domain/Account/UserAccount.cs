﻿using System;
using System.Collections.Generic;
using Yuvia.Domain.Core.Base;

namespace Yuvia.Domain.Core.Domain.Account
{
    public class UserAccount : Entity
    {
        public int AccountId { get; set; }

        [Required]
        [StringLength( 25, MinimumLength = 6 )]
        public string Username { get; set; }

        [Required]
        [StringLength( 25, MinimumLength = 8 )]
        public string Password { get; set; }

        [Required]
        [StringLength( 25 )]
        public string FirstName { get; set; }

        [Required]
        [StringLength( 30 )]
        public string LastName { get; set; }

        [Required]
        [DataType( DataType.EmailAddress )]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public bool HasSignedLatestTerms { get; set; }

        [Required]
        public DateTime SignUpDate { get; set; }

        public IList<SignIn> SignIns { get; set; }
    }
}
