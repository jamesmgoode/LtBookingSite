using System;
using System.ComponentModel.DataAnnotations;

namespace LtBookingSite.Models
{
    public class Player
    {
        [Key]
        [Required]
        public string EmailAddress { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }
        
        public int? PlayerId { get; set; }
        
        public int? MedicalDetailsId { get; set; }
    }
}
