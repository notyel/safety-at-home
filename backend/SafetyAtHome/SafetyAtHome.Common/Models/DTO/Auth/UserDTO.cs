namespace SafetyAtHome.Common.Models.DTO.Auth
{
    public class UserDTO
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
