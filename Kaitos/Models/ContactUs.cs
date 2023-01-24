using System.ComponentModel.DataAnnotations;

namespace Kaitos.Models
{
    public class ContactUs : BaseEntity
    {
        //name, email, phone, subject, Message
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
