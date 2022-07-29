using System;
using System.ComponentModel.DataAnnotations;

namespace BugTracker.Models
{
    public class TicketHistory
    {
        // Primary key
        public int Id { get; set; }

        // Foreign keys
        [Display(Name = "Ticket")]
        public int TicketId { get; set; }

        [Display(Name = "Team Member")]
        public string UserId { get; set; }

        // Ticket History fields
        [Display(Name = "Updated Item")]
        public string Property { get; set; }

        [Display(Name = "Previous")]
        public string OldValue { get; set; }

        [Display(Name = "Current")]
        public string NewValue { get; set; }

        [Display(Name = "Date Modified")]
        public DateTimeOffset Created { get; set; }

        [Display(Name = "Description of Change")]
        public string Description { get; set; }

        // Navigation properties
        public virtual Ticket Ticket { get; set; }
        public virtual BTUser User { get; set; }
    }
}
