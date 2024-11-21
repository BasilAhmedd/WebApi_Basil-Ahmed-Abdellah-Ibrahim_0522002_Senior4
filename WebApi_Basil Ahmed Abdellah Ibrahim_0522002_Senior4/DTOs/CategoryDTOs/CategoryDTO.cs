using System.ComponentModel.DataAnnotations;
using WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.Models;

namespace WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.DTOs.CategoryDTOs
{
    public class CategoryDTO
    {
        [Required]
        public string? Name { get; set; }

        public IList<Movie>? Movies { get; set; }
    }
}
