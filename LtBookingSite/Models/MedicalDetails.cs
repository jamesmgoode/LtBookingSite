using System.ComponentModel.DataAnnotations;

namespace LtBookingSite.Models
{
    public class MedicalDetails
    {
        [Key]
        [Required]
        public int MedicalDetailsId { get; set; }

        [Required]
        public string EmergencyContactName { get; set; }
        
        [Required]
        [Phone]
        public string EmergencyContactPhoneNumber { get; set; }

        public string Notes { get; set; }
    }
}
