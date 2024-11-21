using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.DTOs.MovieDTOs;
using WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.Repo.MovieRepo;

namespace WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieRepo _movieRepo;
        public MoviesController(IMovieRepo movieRepo)
        {
            _movieRepo = movieRepo;
        }
        [HttpPost("All")]
        public IActionResult AddAllthings(Movie_Add_All_DTO dto) 
        {
            if (ModelState.IsValid)
            {
                _movieRepo.AddAll(dto);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        
        }

        [HttpGet("All")]
        public IActionResult GetAllData()
        {
            return Ok(_movieRepo.GetAllMovies());
        }
        [HttpGet("{id}")]
        public IActionResult GetBookById(int id)
        {
            try
            {
                return Ok(_movieRepo.GetMovieById(id));
            }
            catch (Exception ex) { 
               return NotFound(ex.ToString);
            }
        }
    }
}
