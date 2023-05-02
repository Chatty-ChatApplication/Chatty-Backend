using Infrastructure.Config;

namespace WebApi.Config;

public static class DependencyInjection
{
   public static void ConfigServices(this IServiceCollection services, IConfiguration configuration)
   {
      services.AddControllers();
      services.AddEndpointsApiExplorer();
      services.AddSwaggerGen();
      
      services.AddInfrastructure(configuration);
   }
}