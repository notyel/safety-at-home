
namespace SafetyAtHome.Common.Models.Auth
{
    public class UserModel
    {
        public Guid? Id { get; set; } = Guid.NewGuid();
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
