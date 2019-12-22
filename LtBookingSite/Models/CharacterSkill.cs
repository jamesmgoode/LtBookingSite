using System.ComponentModel.DataAnnotations;

namespace LtBookingSite.Models
{
    public class CharacterSkill
    {
        [Key]
        [Required]
        public string Name { get; set; }

        [Required]
        public int Cost { get; set; }
    }
}
