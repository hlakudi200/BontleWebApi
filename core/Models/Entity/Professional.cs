using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace core.Models.Entity
{
    public class Professional
    {
        [Key]
        public int ProfessionalId { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public string? Bio { get; set; }
        public string Rating { get; set; }
        
        [Required]
        public string ServiceArea { get; set; }
        public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; private set; } = DateTime.UtcNow;
        
        public User User { get; set; }
        public ICollection<Service> Services { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<Availability> Availabilities { get; set; }
    }  
}
