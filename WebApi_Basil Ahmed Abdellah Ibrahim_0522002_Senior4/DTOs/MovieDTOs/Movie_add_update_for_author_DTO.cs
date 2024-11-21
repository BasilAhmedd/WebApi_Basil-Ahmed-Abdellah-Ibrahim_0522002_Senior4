using System.ComponentModel.DataAnnotations;
using WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.DTOs.CategoryDTOs;
using WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.DTOs.DirectorDTOs;

namespace WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.DTOs.MovieDTOs
{
    public class Movie_add_update_for_author_DTO
    {
        [Required]
        public string? Title { get; set; }
        public DateTime? RealeaseYear { get; set; }
        public Category_for_movie_DTO? CategoryMovieDTO { get; set; }
    }
}
