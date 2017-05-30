using System.ComponentModel.DataAnnotations;

namespace Yuvia.Domain.Core.Domain.Base
{
    public abstract class Entity
    {
        public bool IsValid => Validator.TryValidateObject( this, new ValidationContext( this ), null, true );
    }
}
