using System.Text.RegularExpressions;
using Domain.Exceptions;

namespace Domain.ValueObjects.Commons;

public readonly partial struct EmailAddress
{
   private static readonly Regex EmailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3}){1,})$");
   
   private readonly string Value { get; init; }

   public EmailAddress(string value)
   {
      if (!EmailRegex.IsMatch(value))
      {
         throw new InvalidEmailAddressException("invalid email address");
      }
      Value = value;
   }

   public static explicit operator string(EmailAddress email)
   {
      return email.Value;
   }
}