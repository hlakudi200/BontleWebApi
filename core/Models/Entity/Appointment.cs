using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace core.Models.Entity
{
    public class Appointment
    {
        [Key]   
        public int AppointmentId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; } // Foreign key to User

        [ForeignKey("Professional")]
        public int ProfessionalId { get; set; } // Foreign key to Professional

        [ForeignKey("Service")]
        public int ServiceId { get; set; } // Foreign key to Service

        [Required]
        public DateTime AppointmentDate { get; set; }

        [Required]
        public string Status { get; set; } // Pending, Confirmed, Cancelled, etc.

        [Required]        
        public decimal TotalCost { get; set; }


        [Required]
        public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;

        [Required]
        public DateTime UpdatedAt { get; private set; } = DateTime.UtcNow;
        // Relationships
        public User User { get; set; }
        public Professional Professional { get; set; }
        public Service Service { get; set; }
    }
}
