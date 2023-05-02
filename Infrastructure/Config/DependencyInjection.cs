using Infrastructure.PrimaryDb;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Config;

public static class DependencyInjection
{
   public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
   {
      services.AddPrimaryDb(configuration);
   }

   private static void AddPrimaryDb(this IServiceCollection services, IConfiguration configuration)
   {
      services.AddDbContext<PrimaryDbContext>(
         options => options.UseNpgsql(configuration["PrimaryDbConnectionString"]));
   }
}