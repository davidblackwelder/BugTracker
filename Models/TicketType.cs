using System.ComponentModel.DataAnnotations;

namespace BugTracker.Models
{
    public class TicketType
    {
        // Primary key
        public int Id { get; set; }

        [Display(Name = "Type Name")]
        public string Name { get; set; }
    }
}
