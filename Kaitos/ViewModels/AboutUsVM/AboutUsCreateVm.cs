using System.ComponentModel.DataAnnotations;

namespace Kaitos.ViewModels.AboutUsVM
{
    public class AboutUsCreateVm
    {
        public string? Iamge { get; set; } = null;
        [Required(ErrorMessage = "Required")]
        public IFormFile ImageFile { get; set; } = null!;
        [Required(ErrorMessage = "Required")]
        public string OurHistory { get; set; } = null!;
        [Required(ErrorMessage = "Required")]
        public string OurVision { get; set; } = null!;
        [Required(ErrorMessage = "Required")]
        public string WhoWeAre { get; set; } = null!;
        [StringLength(255)]
        [Required(ErrorMessage = "Required")]
        public string Title { get; set; } = null!;
    }
}
