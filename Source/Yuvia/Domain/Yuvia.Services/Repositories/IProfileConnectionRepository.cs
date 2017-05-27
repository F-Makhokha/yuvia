using System.Collections.Generic;

namespace Yuvia.Domain.Services.Repositories
{
    public interface IProfileConnectionRepository
    {
        IList<ProfileConnection> Get( int profileId );
        ProfileConnection Get( int originProfileId, int directedProfileId );
        void Insert( int originProfileId, int directedProfileId, Enums.ConnectionStatus status );
        void Update( int originProfileId, int directedProfileId, Enums.ConnectionStatus status );
    }
}