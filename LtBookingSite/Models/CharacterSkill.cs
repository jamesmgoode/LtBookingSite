using System.ComponentModel.DataAnnotations;

namespace LtBookingSite.Models
{
    public class CharacterSkill
    {
        [Key]
        [Required]
        public int? CharacterSkillId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public int Cost { get; set; }
    }
}
