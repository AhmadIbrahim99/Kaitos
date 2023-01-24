using System.ComponentModel.DataAnnotations;

namespace Kaitos.ViewModels.AboutUsVM
{
    public class AboutUsUpdateVm
    {
        public int Id { get; set; }
        public string? Iamge { get; set; }
        public FormFile ImageFile { get; set; } = null!;
        public string OurHistory { get; set; } = null!;
        public string OurVision { get; set; } = null!;
        public string WhoWeAre { get; set; } = null!;
        [StringLength(255)]
        public string Title { get; set; } = null!;
    }
}
