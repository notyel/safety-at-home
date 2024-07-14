using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SafetyAtHome.Domain.Data.Entities.Auth
{
    [Table("Users", Schema = "auth")]
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Username { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string PasswordHash { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
