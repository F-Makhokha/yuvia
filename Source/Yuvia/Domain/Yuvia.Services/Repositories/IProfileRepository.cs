namespace Yuvia.Domain.Services.Repositories
{
    public interface IProfileRepository
    {
        Profile GetProfileWithAllConnections();
        Profile GetProfileWithConnection( int originProfileId, int destinationProfileId );
    }
}