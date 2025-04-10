using Shared.Core.Commons.Bases;

namespace Authentication.Core.Domain.Entities
{
    public class Bitacora : BaseEntity
    {
        public string Message { get; set; } = null!;
        public Guid ModuleId { get; set; }
        public string Module { get; set; } = null!;
        public Guid UserId { get; set; }
        public string? Documento { get; set; }
        public string Action { get; set; } = null!;
        public bool ActionResult { get; set; }
        public User User { get; set; } = null!;
        public DateTime Date { get; set; }
    }
}
