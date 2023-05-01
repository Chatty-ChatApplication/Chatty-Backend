using Domain.Exceptions;

namespace Domain.ValueObjects.Commons;

public readonly struct AuthProviderId
{
   public static bool IsValid(string value)
   {
      return !string.IsNullOrEmpty(value);
   }
   
   public string Value { get; init; }

   public AuthProviderId(string value)
   {
      if (!IsValid(value))
      {
         throw new InvalidAuthProviderIdException();
      }
      Value = value;
   }

   public static explicit operator string(AuthProviderId authProviderId)
   {
      return authProviderId.Value;
   }

   public static explicit operator AuthProviderId(string firebaseIdString)
   {
      return new AuthProviderId(firebaseIdString);
   }
}