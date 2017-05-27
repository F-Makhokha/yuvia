using System.Collections.Generic;
using Yuvia.Domain.Dating.Repositories;
using Yuvia.Domain.Dating.ValueObjects;

namespace Yuvia.Domain.Dating.UseCases
{
    public class ProfileConnectionService
    {
        private readonly IProfileConnectionRepository _profileConnectionRepository;

        public ProfileConnectionService( IProfileConnectionRepository profileConnectionRepository )
        {
            _profileConnectionRepository = profileConnectionRepository;
        }

        public IList<ProfileConnection> GetConnections( int profileId )
        {
            return _profileConnectionRepository.Get( profileId );
        }

        public void ConnectProfile( int originProfileId, int directedProfileId, Enums.ConnectionStatus status )
        {
            ProfileConnection profileConnection = _profileConnectionRepository.Get( originProfileId, directedProfileId );

            if( profileConnection.Equals( default( ProfileConnection ) ) )
                _profileConnectionRepository.Insert( originProfileId, directedProfileId, status );

            else
                _profileConnectionRepository.Update( originProfileId, directedProfileId, status );
        }
    }
}
