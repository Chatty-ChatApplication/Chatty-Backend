using Domain.Exceptions;

namespace Domain.ValueObjects.Commons;

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

   public static explicit operator string(Username username)
   {
      return username.Value;
   }

   public static explicit operator Username(string usernameString)
   {
      return new Username(usernameString);
   }
}