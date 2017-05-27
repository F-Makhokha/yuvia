using System.Collections.Generic;
using Yuvia.Domain.Dating.ValueObjects;
using ProfileConnectionService = Yuvia.Domain.Dating.UseCases.ProfileConnectionService;

namespace Yuvia.Domain.Dating.Repositories
{
    public interface IProfileConnectionRepository
    {
        IList<ProfileConnection> Get( int profileId );
        ProfileConnection Get( int originProfileId, int directedProfileId );
        void Insert( int originProfileId, int directedProfileId, Enums.ConnectionStatus status );
        void Update( int originProfileId, int directedProfileId, Enums.ConnectionStatus status );
    }
}