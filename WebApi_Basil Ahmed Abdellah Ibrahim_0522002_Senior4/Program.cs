
using Microsoft.EntityFrameworkCore;
using WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.Data;
using WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.Repo.CategoryRepo;
using WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.Repo.DirectorRepo;
using WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.Repo.MovieRepo;
using WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.Repo.NationalityRepo;

namespace WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("MyCon")));
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<IMovieRepo, MovieRepo>();
            builder.Services.AddScoped<IDirectoryRepo, DirectoryRepo>();
            builder.Services.AddScoped<INationalityRepo, NationalityRepo>();
            builder.Services.AddScoped<ICategoryRepo, CategoryRepo>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
