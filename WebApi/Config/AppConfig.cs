namespace WebApi.Config;

public static class AppConfig
{
   public static void Config(this WebApplication app)
   {
      if (app.Environment.IsDevelopment())
      {
         app.UseSwagger();
         app.UseSwaggerUI();
      }

      app.UseHttpsRedirection();
      app.UseAuthorization();
      app.MapControllers();  
   }
}