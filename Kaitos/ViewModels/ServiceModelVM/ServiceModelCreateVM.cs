using System.ComponentModel.DataAnnotations;

namespace Kaitos.ViewModels.ServiceModelVM
{
    public class ServiceModelCreateVM
    {
        [StringLength(255)]
        public string Title { get; set; } = null!;
        [StringLength(255)]
        public string ICON { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
}
