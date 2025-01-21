using System.ComponentModel.DataAnnotations;

namespace core.Models.Entity
{
    public class User
    {
        [Key]
        public  int ID { get; set; }

        [Required]
        public  string FirstName { get; set; }

        [Required]
        public  string LastName { get; set; }

        [Required]
        public  string PasswordHash { get; set; }

        [Required]
        public string Phone{ get; set; }
        public int Address { get; set; }
        public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; private set; } = DateTime.UtcNow;

        public ICollection<Appointment>? Appointments { get; set; }
        public ICollection<Review>? Reviews { get; set; }

        public void SetPassword(string plainTextPassword)
        {
            PasswordHash = HashPassword(plainTextPassword);
        }

        public bool ValidatePassword(string plainTextPassword)
        {
            return PasswordHash == HashPassword(plainTextPassword);
        }

        private string HashPassword(string plainTextPassword)
        {
            return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(plainTextPassword));
        }
    }
}
