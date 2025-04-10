namespace Authentication.Core.Domain.Entities
{
    public class RefreshToken
    {
        public Guid Id { get; set; }
        public string Token { get; set; } = null!;
        public int UserId { get; set; }
        public Guid SystemId { get; set; } // Relación con el sistema
        public DateTime ExpiresOnUtc { get; set; }
        public User User { get; set; } = null!;
        public System System { get; set; } = null!; // Propiedad de navegación
    }
}
