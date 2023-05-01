using Domain.Exceptions;

namespace Domain.ValueObjects.UserAccount;

public readonly struct Username
{
   public static bool IsValid(string value)
   {
      return !string.IsNullOrEmpty(value);
   }
   
   public string Value { get; init; }
   
   public Username(string value)
   {
      if (IsValid(value))
      {
         throw new InvalidUsernameException();
      }
      Value = value;
   }
}