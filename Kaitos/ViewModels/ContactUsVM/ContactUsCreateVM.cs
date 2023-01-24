using System.ComponentModel.DataAnnotations;

namespace Kaitos.ViewModels.ContactUsVM
{
    public class ContactUsCreateVM
    {
        [StringLength(255)]
        public string Name { get; set; } = null!;
        [EmailAddress]
        public string Email { get; set; } = null!;
        [StringLength(255)]
        public string Phone { get; set; } = null!;
        [StringLength(255)]
        public string Subject { get; set; } = null!;
        public string Message { get; set; } = null!;
    }
}
