using System.ComponentModel.DataAnnotations;

namespace LtBookingSite.Models
{
    public class Character
    {
        [Key]
        [Required]
        public int? CharacterId { get; set; }

        [Required]
        public string EmailAddress { get; set; }

        // Add basic fields
        [Required]
        [StringLength(50)]
        public string CharacterName { get; set; }

        // Add CSs

        // Add Osps

        // Add lammies/special creatures
    }
}
