namespace OpenDmsCore.Core.DTOs
{
    public class TeamDto
    {
        public int Id { get; set; }
        public int EntityId { get; set; }
        public string TeamName { get; set; }
        public string PathRoot { get; set; }
        public string TelephoneNumber { get; set; }
        public string HostName { get; set; }
        public int? PortNumber { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }
    }
}
