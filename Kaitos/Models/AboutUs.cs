using System.ComponentModel.DataAnnotations;

namespace Kaitos.Models
{
    public class AboutUs : BaseEntity
    {
        //Title, WhoWeAre, OurVision, OurHistory, Iamge
        [StringLength(255)]
        public string Iamge { get; set; } = null!;
        public string OurHistory { get; set; } = null!;
        public string OurVision { get; set; } = null!;
        public string WhoWeAre { get; set; } = null!;
        [StringLength(255)]
        public string Title { get; set; } = null!;
    }
}
