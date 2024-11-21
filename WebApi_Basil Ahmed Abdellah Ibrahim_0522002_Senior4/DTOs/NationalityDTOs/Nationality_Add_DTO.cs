using System.ComponentModel.DataAnnotations;

namespace WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.DTOs.NationalityDTOs
{
    public class Nationality_Add_DTO
    {
        [Required]
        public string? Name { get; set; }

    }
}
