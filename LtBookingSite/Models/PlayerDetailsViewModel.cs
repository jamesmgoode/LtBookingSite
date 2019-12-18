using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LtBookingSite.Models
{
    public class PlayerDetailsViewModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime? DateOfBirth { get; set; }

        [Required]
        public string EmergencyContactName { get; set; }

        [Required]
        [Phone]
        public string EmergencyContactPhoneNumber { get; set; }

        public string Notes { get; set; }
    }
}
