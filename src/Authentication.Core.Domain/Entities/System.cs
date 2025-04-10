using Shared.Core.Commons.Bases;

namespace Authentication.Core.Domain.Entities
{
    public class System : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string BaseUrl { get; set; } = null!;
        public string ApiKey { get; set; } = null!;
    }
}
