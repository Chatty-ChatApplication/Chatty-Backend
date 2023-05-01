namespace Domain.Exceptions;

public class InvalidEmailAddressException : Exception
{
   public InvalidEmailAddressException(string? message) : base(message) {}
}