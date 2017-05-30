using System.Collections.Generic;
using Yuvia.Domain.Core.Domain.Interaction;

namespace Yuvia.Domain.Services.Repositories
{
    public interface IProfileConnectionRepository
    {
        IList<ProfileConnection> Get( int profileId );
        ProfileConnection Get( int originProfileId, int directedProfileId );
        void Insert( int originProfileId, int directedProfileId, ConnectionStatus status );
        void Update( int originProfileId, int directedProfileId, ConnectionStatus status );
    }
}