using Shared.Core.Commons.Bases;

namespace Authentication.Core.Domain.Entities
{
    public class SystemUser : BaseEntity
    {
        public Guid SystemId { get; set; } 
        public System System { get; set; } = null!;

        public Guid UserId { get; set; } 
        public User User { get; set; } = null!;

        public DateTime AssignedAt { get; set; } = DateTime.UtcNow; 
        public bool IsActive { get; set; } = true;
    }
}
