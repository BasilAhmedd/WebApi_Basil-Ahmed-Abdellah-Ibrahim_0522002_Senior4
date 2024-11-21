using Microsoft.EntityFrameworkCore;
using WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.Data;
using WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.DTOs.CategoryDTOs;
using WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.Models;

namespace WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.Repo.CategoryRepo
{
    public class CategoryRepo : ICategoryRepo
    {
        private readonly AppDbContext _context;
        public CategoryRepo(AppDbContext context)
        {
            _context = context;
        }
        public void AddCategory(Category_Add_Update_DTO dto)
        {
            var Cat = new Category
            {
                Name = dto.Name,

            };
            _context.Categories.Add(Cat);
            _context.SaveChanges();
        }

        public void UpdateCategory(Category_Add_Update_DTO dto, int id)
        {
            var cat = _context.Categories.FirstOrDefault(d => d.Id == id);
            if (cat == null)
            {
                throw new KeyNotFoundException("not found");
            }
            cat.Name = dto.Name;
            _context.Categories.Update(cat);
            _context.SaveChanges();

        }
    }
}
