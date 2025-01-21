using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace core.Models.Entity
{
    public class Availability
    {
        [Key]
        public int AvailabilityId { get; set; }

        [ForeignKey("Professional")]
        public int ProfessionalId { get; set; } // Foreign key to Professional

        [Required]
        public string DayOfWeek { get; set; } // e.g., Monday, Tuesday, etc.

        [Required]
        public TimeSpan StartTime { get; set; }

        [Required]
        public TimeSpan EndTime { get; set; }

        [Required]
        public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;
        // Relationships
        public Professional Professional { get; set; }
    }
}
