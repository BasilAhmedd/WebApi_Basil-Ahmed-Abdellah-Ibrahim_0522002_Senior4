using System.ComponentModel.DataAnnotations;
using WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.DTOs.CategoryDTOs;
using WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.DTOs.DirectorDTOs;

namespace WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.DTOs.MovieDTOs
{
    public class Movie_Add_All_DTO
    {
        [Required]
        public string? Title { get; set; }
        public DateTime? RealeaseYear { get; set; }
        public IList<Director_for_movie_DTO>? directorsMovieDTO { get; set; }

        public Category_for_movie_DTO? CategoryMovieDTO { get; set; }
    }
}
