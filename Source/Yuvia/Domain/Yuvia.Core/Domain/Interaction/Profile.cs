using System.Collections.Generic;

namespace Yuvia.Domain.Core.Domain.Interaction
{
    public class Profile
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Headline { get; set; }

        /** Location Information **/
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Zip { get; set; }

        public string Occupation { get; set; }

        public RelationshipStatus RelationshipStatus { get; set; }

        public IList<ProfileQuestion> ProfileAnswers { get; set; }

        public IList<ProfileConnection> ProfileConnections { get; }


        public Profile()
        {
            ProfileConnections = new List<ProfileConnection>();
        }                     
    }

    public enum RelationshipStatus
    {
        Single, Divorced, Widowed
    }
}