using System.ComponentModel.DataAnnotations;

namespace WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }

        public IList<Movie>? Movies { get; set; }
    }
}
