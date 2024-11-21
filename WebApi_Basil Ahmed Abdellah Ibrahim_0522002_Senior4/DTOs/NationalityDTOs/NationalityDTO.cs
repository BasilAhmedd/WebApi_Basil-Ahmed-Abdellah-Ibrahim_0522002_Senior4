using System.ComponentModel.DataAnnotations;
using WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.Models;

namespace WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.DTOs.NationalityDTOs
{
    public class NationalityDTO
    {
        [Required]
        public string? Name { get; set; }

        public int DirectorId { get; set; }
        public Director? Director { get; set; }
    }
}
