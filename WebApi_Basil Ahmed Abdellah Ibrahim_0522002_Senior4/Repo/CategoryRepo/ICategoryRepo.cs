using WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.DTOs.CategoryDTOs;

namespace WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.Repo.CategoryRepo
{
    public interface ICategoryRepo
    {
        void AddCategory(Category_Add_Update_DTO dto);
        void UpdateCategory(Category_Add_Update_DTO dto, int id);
    }
}
