using Microsoft.EntityFrameworkCore;
using SoulmateSeeker.Data;
using SoulmateSeeker.Helpers;
using SoulmateSeeker.Interfaces;
using SoulmateSeeker.Services;

namespace SoulmateSeeker.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static void AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddAutoMapper(typeof(AutoMapperProfiles));

            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IUserRepository, UserRepository>();

            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(config.GetConnectionString("SoulSeekerDbConnection"));
            });
        }
    }
}
