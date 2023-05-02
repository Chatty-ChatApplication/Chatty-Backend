using Domain.Contracts.Commons;

namespace Domain.Contracts.PrimaryDb;

public interface IPrimaryDbContext : IUnitOfWork
{
   public Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());
}