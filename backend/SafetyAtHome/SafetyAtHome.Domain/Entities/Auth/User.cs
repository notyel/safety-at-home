using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SafetyAtHome.Domain.Data.Models;

namespace SafetyAtHome.Domain.Data.Entities.Auth
{
    [Table("Users", Schema = "auth")]
    public class User : EntityAudit
    {
        [Required]
        [MaxLength(50)]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string PasswordHash { get; set; }
    }
}
