using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yuvia.Core
{
    public abstract class Entity
    {
        public bool IsValid { get { return Validator.TryValidateObject( this, new ValidationContext( this ), null, true ); } }
    }
}
