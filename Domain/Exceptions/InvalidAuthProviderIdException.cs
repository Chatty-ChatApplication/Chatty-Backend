namespace Domain.Exceptions;

public class InvalidAuthProviderIdException : Exception
{
   public InvalidAuthProviderIdException(string? message = null) : base(message)
   {
   }
}