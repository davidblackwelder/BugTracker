using System;
using System.ComponentModel.DataAnnotations;

namespace BugTracker.Models
{
    public class Notification
    {
        // Primary key
        public int Id { get; set; }

        // Foreign keys
        [Display(Name = "Ticket")]
        public int TicketId { get; set; }

        [Required]
        [Display(Name = "Recipient")]
        public string RecipientId { get; set; }

        [Required]
        [Display(Name = "Sender")]
        public string SenderId { get; set; }

        // Notification fields
        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Message")]
        public string Messasge { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Created")]
        public DateTimeOffset Created { get; set; }

        [Display(Name = "Has been viewed")]
        public bool Viewed { get; set; }

        // Navigation properties
        public virtual Ticket Ticket { get; set; }

        public virtual BTUser Recipient { get; set; }

        public virtual BTUser Sender { get; set; }
    }
}
