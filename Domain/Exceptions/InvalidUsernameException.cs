namespace Domain.Exceptions;

public class InvalidUsernameException : Exception
{
   public InvalidUsernameException(string? message = null) : base(message)
   {
   }
}