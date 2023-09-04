using Microsoft.EntityFrameworkCore;
using SoulmateSeeker.Data;
using SoulmateSeeker.Interfaces;
using SoulmateSeeker.Services;

namespace SoulmateSeeker.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static void AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<ITokenService, TokenService>();
            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(config.GetConnectionString("SoulSeekerDbConnection"));
            });
        }
    }
}
