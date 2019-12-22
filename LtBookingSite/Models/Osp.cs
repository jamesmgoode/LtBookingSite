using System.ComponentModel.DataAnnotations;

namespace LtBookingSite.Models
{
    public class Osp
    {
        [Key]
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
