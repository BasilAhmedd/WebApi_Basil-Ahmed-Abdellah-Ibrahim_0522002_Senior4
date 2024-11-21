using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.DTOs.DirectorDTOs;
using WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.Repo.DirectorRepo;
using WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.Repo.MovieRepo;

namespace WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectoriesController : ControllerBase
    {
        private readonly IDirectoryRepo _directoryRepo;
        public DirectoriesController(IDirectoryRepo directoryRepo)
        {
            _directoryRepo = directoryRepo;
        }
        [HttpPost]
        public IActionResult AddDirector(Director_Add_Update_DTO dto)
        {
            if (ModelState.IsValid)
            {

                _directoryRepo.AddDirectory(dto);
                return Ok();


            }
            return BadRequest();

        }
        [HttpPut("{id}")]
        public IActionResult UpdateDirector(Director_Add_Update_DTO dto,int id)
        {
            if (ModelState.IsValid) {
              
                _directoryRepo.UpdateDirectory(dto, id);
                return Accepted();

            }
            return NotFound();

        }
        [HttpDelete]
        public IActionResult DeleteDirector(int id) 
        {
            try
            {
                _directoryRepo.DeleteDirectory(id);
                return NoContent();
            }
            catch (Exception ex) {
              return NotFound(ex.Message);
            }

        }
    }
}
