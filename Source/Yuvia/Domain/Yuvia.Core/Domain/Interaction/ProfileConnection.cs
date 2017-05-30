namespace Yuvia.Domain.Core.Domain.Interaction
{
    public struct ProfileConnection
    {
        public int OriginProfileId { get; set; }
        public int DirectedProfileId { get; set; }
        public ConnectionStatus ConnectionStatus { get; set; }
    }

    public enum ConnectionStatus
    {
        Invited, Connected, Rejected, Blocked
    }
}
