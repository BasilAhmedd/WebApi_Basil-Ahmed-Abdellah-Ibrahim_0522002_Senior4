using Microsoft.EntityFrameworkCore;
using WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.Data;
using WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.DTOs.DirectorDTOs;
using WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.DTOs.NationalityDTOs;
using WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.Models;

namespace WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.Repo.DirectorRepo
{
    public class DirectoryRepo : IDirectoryRepo
    {
        private readonly AppDbContext _context;
        public DirectoryRepo(AppDbContext context)
        {
            _context = context;
        }
        public void AddDirectory(Director_Add_Update_DTO dto)
        {
            var Director = new Director
            {
               Contact = dto.Contact,
               Email = dto.Email,
               Name = dto.Name,
               Nationality = new Nationality
               {
                   Name = dto.NationalityDTO.Name,
               }

            };
            _context.Directors.Add(Director);
            _context.SaveChanges();
        }

        public void DeleteDirectory(int id)
        {
            var dir = _context.Directors.FirstOrDefault(d => d.Id == id);
            if (dir != null)
            {
                _context.Directors.Remove(dir);
                _context.SaveChanges();
            }
            else
            {
               throw new KeyNotFoundException();
            }
        }
        public void UpdateDirectory(Director_Add_Update_DTO dto, int id)
        {
            var directoryy = _context.Directors.Include(x=>x.Movies).FirstOrDefault(d => d.Id == id);


            directoryy.Contact = dto.Contact;
            directoryy.Email = dto.Email;
            directoryy.Name = dto.Name;
            directoryy.Nationality = new Nationality
            {
                Name = dto.Name,
            };
            directoryy.Movies = dto.MoviesDto.Select(x => new Movie{
                Title = x.Title,
                RealeaseYear = x.RealeaseYear,
                Category = new Category
                {
                    Name = x.CategoryMovieDTO.Name
                },

                
            }).ToList();

            
            _context.Directors.Update(directoryy);
            _context.SaveChanges();
        }
    }
}
