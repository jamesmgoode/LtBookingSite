using System.ComponentModel.DataAnnotations;

namespace LtBookingSite.Models
{
    public class FacebookEvent
    {
        [Key]
        [Required]
        public int EventId { get; set; }

        [Required]
        public string EventName { get; set; }

        [Required]
        public string EventLink { get; set; }
    }
}
