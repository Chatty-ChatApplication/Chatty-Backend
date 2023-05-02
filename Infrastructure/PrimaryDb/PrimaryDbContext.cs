using Domain.Contracts.PrimaryDb;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.PrimaryDb;

public class PrimaryDbContext : DbContext, IPrimaryDbContext
{
   private readonly IConfiguration _configuration;
   
   internal DbSet<UserAccount> UserAccounts { get; set; } = null!;

   public PrimaryDbContext(DbContextOptions<PrimaryDbContext> options, IConfiguration configuration) : base(options)
   {
      _configuration = configuration;
   }

   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
   {
      optionsBuilder.UseNpgsql(_configuration["PrimaryDbConnectionString"]);
   }
}