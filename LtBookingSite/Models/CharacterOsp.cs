using System.ComponentModel.DataAnnotations;

namespace LtBookingSite.Models
{
    public class CharacterOsp
    {
        [Key]
        [Required]
        public int? CharacterId { get; set; }

        [Key]
        [Required]
        public int? OspId { get; set; }
    }
}
