namespace Kaitos.Models
{
    public class BaseEntity : IBaseEntity
    {
        public int Id { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
    }
}
