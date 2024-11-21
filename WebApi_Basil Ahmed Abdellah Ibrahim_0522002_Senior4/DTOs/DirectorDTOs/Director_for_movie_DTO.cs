using System.ComponentModel.DataAnnotations;
using WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.DTOs.NationalityDTOs;
using WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.Models;

namespace WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.DTOs.DirectorDTOs
{
    public class Director_for_movie_DTO
    {
        [Required]
        public string? Name { get; set; }
        [Phone]
        public string? Contact { get; set; }
        [EmailAddress]
        public string? Email { get; set; }

        public Nationality_Add_DTO? NationalityDTO { get; set; }

    }
}
