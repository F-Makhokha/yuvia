using System.Collections.Generic;

namespace Yuvia.Domain.Core.Domain.Connection
{
    public class Profile
    {
        public int Id { get; }

        public string Username { get; set; }

        public string Headline { get; set; }

        /* Location Information */
        public string City { get; set; }
        public string State { get; set; }
        public string Occupation { get; set; }

        public StatusTypes.RelationshipStatus RelationshipStatus { get; set; }
        public StatusTypes.KidDesireStatus KidsDesireStatus { get; set; }

        public IList<ProfileAnswer> ProfileAnswers { get; set; }

        public IList<ProfileConnection> ProfileConnections { get; }


        public Profile()
        {
            ProfileConnections = new List<ProfileConnection>();
        }                     
    }
}