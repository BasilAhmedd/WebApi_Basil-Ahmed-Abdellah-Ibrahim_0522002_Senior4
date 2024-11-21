using System.ComponentModel.DataAnnotations;
using WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.Models;

namespace WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.DTOs.DirectorDTOs
{
    public class DirectorDTO
    {
        [Required]
        public string? Name { get; set; }
        [Phone]
        public string? Contact { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        public IList<Movie>? Movies { get; set; }
    }
}
