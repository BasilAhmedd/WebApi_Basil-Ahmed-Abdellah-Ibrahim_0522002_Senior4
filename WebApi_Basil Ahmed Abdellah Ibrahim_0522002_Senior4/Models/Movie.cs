using System.ComponentModel.DataAnnotations;

namespace WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }  
        public DateTime? RealeaseYear { get; set; }
        public IList<Director>? directors { get; set; }

        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        
    }
}
