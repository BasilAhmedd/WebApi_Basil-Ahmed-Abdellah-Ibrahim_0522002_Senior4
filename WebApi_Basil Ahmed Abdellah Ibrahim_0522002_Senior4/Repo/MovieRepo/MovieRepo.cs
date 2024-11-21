using Microsoft.EntityFrameworkCore;
using WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.Data;
using WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.DTOs.CategoryDTOs;
using WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.DTOs.DirectorDTOs;
using WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.DTOs.MovieDTOs;
using WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.DTOs.NationalityDTOs;
using WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.Models;

namespace WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.Repo.MovieRepo
{
    public class MovieRepo : IMovieRepo
    {
        private readonly AppDbContext _context;
        public MovieRepo(AppDbContext context)
        {
            _context = context;
        }

        public void AddAll(Movie_Add_All_DTO dto)
        {
           var movie = new Movie
               {
                RealeaseYear = dto.RealeaseYear,
                Title = dto.Title,
                directors = dto.directorsMovieDTO.Select(x=>new Director
                {
                    Contact = x.Contact,
                    Email = x.Email,
                    Name = x.Name,  
                    Nationality = new Nationality
                    {
                        Name = x.NationalityDTO.Name,
                    }
                    
                }).ToList(),
                Category = new Category
                {
                    Name = dto.CategoryMovieDTO.Name
                }
           };
            _context.Movies.Add(movie);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var movie = _context.Movies.FirstOrDefault(x => x.Id == id);
            if (movie == null)
            {
                throw new KeyNotFoundException("not found");
            }
            _context.Movies.Remove(movie);
            _context.SaveChanges();
        }

        public IEnumerable<Movie_Get_All_DTO> GetAllMovies()
        {
            var movie = _context.Movies.Include(x=>x.directors);
            return movie.Select(x=> new Movie_Get_All_DTO
            {
                RealeaseYear= x.RealeaseYear,
                Title = x.Title,
                CategoryMovieDTO = new Category_for_movie_DTO
                {
                    Name = x.Category.Name,
                },
                directorsMovieDTO = x.directors.Select(x=>new Director_for_movie_DTO
                {
                    Contact= x.Contact,
                    Email=x.Email,
                    Name = x.Name,
                    NationalityDTO = new Nationality_Add_DTO
                    {
                        Name = x.Name
                    }
                    
                }).ToList(),
                

            }).ToList();
        }

        public Movie_Get_All_DTO GetMovieById(int id)
        {
            var movie = _context.Movies.Include(x => x.directors).Include(x=>x.Category).FirstOrDefault(x=>x.Id==id);
            if(movie == null)
            {
                throw new KeyNotFoundException("not found");
            }
            return new Movie_Get_All_DTO
            {
                RealeaseYear = movie.RealeaseYear,
                Title = movie.Title,
                CategoryMovieDTO = new Category_for_movie_DTO
                {
                    Name = movie.Category.Name,
                },
                directorsMovieDTO = movie.directors.Select(x => new Director_for_movie_DTO
                {
                    Contact = x.Contact,
                    Email = x.Email,
                    Name = x.Name,
                    NationalityDTO = new Nationality_Add_DTO
                    {
                        Name = x.Name
                    }

                }).ToList(),
                //directorsMovieDTO = movie.directors.Where(movie.directors.Contains())
                //directorsMovieDTO = movie.directors.Select(x => new Director_for_movie_DTO
                //{
                //    Contact = x.Contact,
                //    Email = x.Email,
                //    Name = x.Name,
                //    NationalityDTO = new Nationality_Add_DTO
                //    {
                //        Name = x.Nationality.Name,
                //    }
                //}).ToList(),


            };
        }
    }
}
