using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.DTOs.NationalityDTOs;
using WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.Repo.DirectorRepo;
using WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.Repo.NationalityRepo;

namespace WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NationalitiesController : ControllerBase
    {
        private readonly INationalityRepo _nationalityRepo;
        public NationalitiesController(INationalityRepo nationalityRepo)
        {
            _nationalityRepo = nationalityRepo;
        }
        [HttpPost]
        public IActionResult AddNation(Nationality_Add_DTO dto) {
            if (ModelState.IsValid)
            {
                _nationalityRepo.AddNationality(dto);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpDelete]
        public IActionResult DeleteNations(int id) {
            _nationalityRepo.DeleteNation(id);
            return NoContent();
        }
    }
}
