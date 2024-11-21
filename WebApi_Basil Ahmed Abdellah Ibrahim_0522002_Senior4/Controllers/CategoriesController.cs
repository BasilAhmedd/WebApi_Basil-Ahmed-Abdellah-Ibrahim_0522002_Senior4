using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.DTOs.CategoryDTOs;
using WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.Repo.CategoryRepo;
using WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.Repo.DirectorRepo;

namespace WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepo _categoryRepo;
        public CategoriesController(ICategoryRepo categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }
        [HttpPost]
        public IActionResult AddCat(Category_Add_Update_DTO dto)
        {
            if (ModelState.IsValid)
            {
                _categoryRepo.AddCategory(dto);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCat(Category_Add_Update_DTO dto, int id)
        {
            if (ModelState.IsValid)
            {
                _categoryRepo.UpdateCategory(dto,id);
                return Accepted();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
