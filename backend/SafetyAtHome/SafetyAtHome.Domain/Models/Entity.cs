using System.ComponentModel.DataAnnotations;

namespace SafetyAtHome.Domain.Data.Models
{
    public abstract class Entity
    {
        [Key]
        public Guid Id { get; protected set; } = Guid.NewGuid();
    }
}
