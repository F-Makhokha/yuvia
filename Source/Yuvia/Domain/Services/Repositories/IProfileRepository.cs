using Yuvia.Domain.Dating.Entities;

namespace Yuvia.Domain.Dating.Repositories
{
    public interface IProfileRepository
    {
        Profile GetProfileWithAllConnections();
        Profile GetProfileWithConnection( int originProfileId, int destinationProfileId );
    }
}