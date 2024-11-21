using System.ComponentModel.DataAnnotations;

namespace WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.DTOs.CategoryDTOs
{
    public class Category_Add_Update_DTO
    {
        [Required]
        public string? Name { get; set; }
    }
}
