using System;
using System.ComponentModel.DataAnnotations;

namespace BugTracker.Models
{
    public class TicketComment
    {
        // Primary key
        public int Id { get; set; }

        // Foreign keys
        [Display(Name = "Ticket")]
        public int TicketId { get; set; }

        [Display(Name = "Team Member")]
        public string UserId { get; set; }

        // Ticket Comment fields
        [Display(Name = "Member Comment")]
        public string Comment { get; set; }

        [Display(Name = "Date")]
        public DateTimeOffset Created { get; set; }

        // Navigation properties
        public virtual Ticket Ticket { get; set; }
        public virtual BTUser User { get; set; }
    }
}
