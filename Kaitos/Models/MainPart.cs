using System.ComponentModel.DataAnnotations;

namespace Kaitos.Models
{
    public class MainPart : BaseEntity
    {
        //title, description, Image, Vedio
        [StringLength(255)]
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        [StringLength(255)]
        public string Image { get; set; } = null!;
        [StringLength(255)]
        public string Vedio { get; set; } = null!;
    }
}
