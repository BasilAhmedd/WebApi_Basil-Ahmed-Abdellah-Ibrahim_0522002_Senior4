using WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.Data;
using WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.DTOs.NationalityDTOs;
using WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.Models;

namespace WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.Repo.NationalityRepo
{
    public class NationalityRepo : INationalityRepo
    {
        private readonly AppDbContext _context;
        public NationalityRepo(AppDbContext context)
        {
            _context = context;
        }
        public void AddNationality(Nationality_Add_DTO dto)
        {
            var Nation = new Nationality
            {
                Name = dto.Name,

            };
            _context.Nationalities.Add(Nation);
            _context.SaveChanges();
        }

        public void DeleteNation(int id)
        {
            var Nation = _context.Nationalities.FirstOrDefault(x => x.Id == id);
            _context.Nationalities.Remove(Nation);
            _context.SaveChanges();
        }
    }
}
