using System.ComponentModel.DataAnnotations;

namespace LtBookingSite.Models
{
    public class Osp
    {
        [Key]
        public int? OspId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
