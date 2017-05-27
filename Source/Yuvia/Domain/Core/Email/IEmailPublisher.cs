namespace Yuvia.Core.Email
{
    public interface IEmailPublisher
    {
        void Send( Email email );
    }
}
