using System.ComponentModel.DataAnnotations;

namespace Kaitos.Models
{
    public class Setting : BaseEntity
    {
        //Title, SubTitle, Address, ICON
        [StringLength(255)]
        public string Title { get; set; } = null!;
        [StringLength(255)]
        public string SubTitle { get; set; } = null!;
        [StringLength(255)]
        public string Address { get; set; } = null!;
        [StringLength(255)]
        public string ICON { get; set; } = null!;
    }
}
