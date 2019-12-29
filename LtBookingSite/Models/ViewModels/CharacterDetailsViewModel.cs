using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LtBookingSite.Models.ViewModels
{
    public class CharacterDetailsViewModel
    {
        [Required]
        [StringLength(50)]
        [Display(Name = "Character Name")]
        public string CharacterName { get; set; }
    }
}
