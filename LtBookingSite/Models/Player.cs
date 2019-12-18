using System;

namespace LtBookingSite.Models
{
    public class Player
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int PlayerId { get; set; }
        public MedicalDetails MedicalDetails { get; set; }
    }
}
