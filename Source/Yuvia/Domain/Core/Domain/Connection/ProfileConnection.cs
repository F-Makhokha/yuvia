namespace Yuvia.Domain.Dating.ValueObjects
{
    public struct ProfileConnection
    {
        public int OriginProfileId { get; set; }
        public int DirectedProfileId { get; set; }
        public Enums.ConnectionStatus ConnectionStatus { get; set; }
    }
}
