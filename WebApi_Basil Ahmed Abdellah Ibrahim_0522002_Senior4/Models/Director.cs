using System.ComponentModel.DataAnnotations;

namespace WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.Models
{
    public class Director
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Phone]
        public string? Contact { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        public int NationalityId { get; set; }
        public Nationality? Nationality { get; set; }
        public IList<Movie>? Movies { get; set; }
    }
}
