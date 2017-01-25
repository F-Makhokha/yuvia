using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Yuvia.Web.Models
{
    public class RegistrationViewModel
    {
        [Required]
        [StringLength( 25, MinimumLength = 6 )]
        public string Username { get; set; }

        [Required]
        [StringLength( 25, MinimumLength = 6 )]
        public string Password { get; set; }

        [Required]
        [DataType( DataType.EmailAddress )]
        [EmailAddress]
        public string Email { get; set; }
    }
}