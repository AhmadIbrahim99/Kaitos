using System.ComponentModel.DataAnnotations;

namespace Kaitos.Models
{
    public class ServiceModel : BaseEntity
    {
        //ICON, title, description
        [StringLength(255)]
        public string Title { get; set; } = null!;
        [StringLength(255)]
        public string ICON { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
}
