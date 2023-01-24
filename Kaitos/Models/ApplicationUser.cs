using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Kaitos.Models
{
    public class ApplicationUser : IdentityUser
    {
        [StringLength(255)]
        public string Image { get; set; } = null!;
        [StringLength(255)]
        public string FullName { get; set; } = null!;
        public List<Blog>? Blogs { get; set; }
    }
}
