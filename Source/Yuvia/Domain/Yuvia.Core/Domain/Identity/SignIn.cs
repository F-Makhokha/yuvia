using System;
using System.ComponentModel.DataAnnotations;

namespace Yuvia.Domain.Core.Domain.Identity
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