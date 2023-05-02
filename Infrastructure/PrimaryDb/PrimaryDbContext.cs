using Domain.Contracts.PrimaryDb;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.PrimaryDb;

public class PrimaryDbContext : DbContext, IPrimaryDbContext
{
   internal DbSet<UserAccount> UserAccounts { get; set; } = null!;

   public PrimaryDbContext(DbContextOptions<PrimaryDbContext> options) : base(options)
   {
   }
}