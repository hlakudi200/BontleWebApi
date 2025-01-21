using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace core.Models.Entity
{
    public class Service
    {
        [Key]
        public int ServiceId { get; set; }

        [ForeignKey("Professional")]
        public int ProfessionalId { get; set; }
        
        [Required]
        public string ServiceName { get; set; }
       
        [Required]
        public decimal Price { get; set; }

        [Required]
        public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;
        public Professional ? Professional { get; set; } 
    }
}
