using WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.DTOs.MovieDTOs;

namespace WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.Repo.MovieRepo
{
    public interface IMovieRepo
    {
        IEnumerable<Movie_Get_All_DTO> GetAllMovies();

        Movie_Get_All_DTO GetMovieById(int id);

        void AddAll(Movie_Add_All_DTO dto);
        void Delete(int id);
    }
}
