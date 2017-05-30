using System.Collections.Generic;

namespace Yuvia.Domain.Core.Domain.Interaction
{
    public class GroupMessage
    {
        public Profile From { get; set; }
        public IList<Profile> To { get; set; }
    }
}
