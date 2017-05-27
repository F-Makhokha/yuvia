using System;

namespace Yuvia.Domain.Core.Domain.Account
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