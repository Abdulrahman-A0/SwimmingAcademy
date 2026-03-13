using Domain.Exceptions.Abstraction;


namespace Domain.Exceptions.ValidationExceptions
{
    public class LocationValidationException : ValidationException
    {
        public LocationValidationException(
            IDictionary<string, string[]> errors)
            : base(errors)
        {
            
        }
    }
}
