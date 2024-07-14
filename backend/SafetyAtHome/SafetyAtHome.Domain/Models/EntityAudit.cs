namespace SafetyAtHome.Domain.Data.Models
{
    public abstract class EntityAudit : Entity
    {
        public bool IsDeleted { get; set; } = false;
        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
        public Guid CreatedBy { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; } = null!;
        public Guid? UpdatedBy { get; set; } = null!;
    }
}
