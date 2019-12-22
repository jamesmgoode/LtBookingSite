using System.ComponentModel.DataAnnotations;

namespace LtBookingSite.Models
{
    public class CharacterCs
    {
        [Key]
        [Required]
        public int? CharacterId { get; set; }

        [Key]
        [Required]
        public int? CharacterSkillId { get; set; }
    }
}
