namespace Domain.Entities;

public abstract class EntityBase
{
   private protected EntityBase(Guid id)
   {
      Id = id;
   }

   public Guid Id { get; init; }

   public DateTime InsertedAt { get; init; }
   
   public DateTime UpdatedAt { get; set; }
}