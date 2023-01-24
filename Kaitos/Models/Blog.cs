using System.ComponentModel.DataAnnotations;

namespace Kaitos.Models
{
    public class Blog : BaseEntity
    {
        //image, CreatedByWhome, Title, Description
        [StringLength(255)]
        public string Title { get; set; } = null!;
        [StringLength(255)]
        public string Image { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string CreatorId { get; set; } = null!;
        public ApplicationUser? Creator { get; set; }

    }
}
