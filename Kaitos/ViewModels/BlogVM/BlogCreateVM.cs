using System.ComponentModel.DataAnnotations;

namespace Kaitos.ViewModels.BlogVM
{
    public class BlogCreateVM
    {
        [StringLength(255)]
        public string Title { get; set; } = null!;
        [StringLength(255)]
        public string Image { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string CreatorId { get; set; } = null!;
    }
}
