using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class University
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        public string Founded { get; set; }
        [Required]
        public string Address { get; set; }

    }
}