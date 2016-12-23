using System;
using System.ComponentModel.DataAnnotations;

namespace Yuvia.Core.Account
{
    public class SignIn
    {
        [Required]
        [DataType( DataType.DateTime )]
        public DateTime Timestamp { get; set; }

        [Required]
        public string IPAddress { get; set; }

        [Required]
        public string Location { get; set; }
    }
}