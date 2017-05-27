namespace Yuvia.Domain.Core.Email
{
    public interface IEmailPublisher
    {
        void Send( Email email );
    }
}
