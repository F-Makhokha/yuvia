namespace Yuvia.Domain.Core.Base
{
    public abstract class Entity
    {
        public bool IsValid => Validator.TryValidateObject( this, new ValidationContext( this ), null, true );
    }
}
