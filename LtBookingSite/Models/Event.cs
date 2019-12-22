using System;
using System.ComponentModel.DataAnnotations;

namespace LtBookingSite.Models
{
    public class Event
    {
        [Key]
        [Required]
        public int EventId { get; set; }

        [Required]
        public string EventName { get; set; }

        public string EventLink { get; set; }

        [Required]
        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string EventDescription { get; set; }
    }
}
