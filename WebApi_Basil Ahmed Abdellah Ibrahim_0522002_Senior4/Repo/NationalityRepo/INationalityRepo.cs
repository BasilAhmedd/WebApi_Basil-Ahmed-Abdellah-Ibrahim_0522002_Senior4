using WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.DTOs.NationalityDTOs;

namespace WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.Repo.NationalityRepo
{
    public interface INationalityRepo
    {
        void AddNationality(Nationality_Add_DTO dto);
        void DeleteNation(int id);
    }
}
