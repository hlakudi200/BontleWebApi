using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace core.Models.Entity
{
    public class Review
    {
        [Key]
        public int ReviewId  { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        [ForeignKey("Professional")]
        public int ProfessionalId { get; set; } // Foreign Key

        [Required]
        public int Rating { get; set; }
        public string ReviewText { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;


        public User User { get; set; } = null!;
        public Professional Professional { get; set; } = null!;

    }
}
