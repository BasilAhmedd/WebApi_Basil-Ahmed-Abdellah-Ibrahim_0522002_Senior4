using System.ComponentModel.DataAnnotations;
using WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.Models;

namespace WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.DTOs.MovieDTOs
{
    public class MovieDTO
    {
        [Required]
        public string? Title { get; set; }
        public DateTime? RealeaseYear { get; set; }
        public IList<Director>? directors { get; set; }

        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
