using System.ComponentModel.DataAnnotations;

namespace ItAcademy.Demo.ClassWork.Client.Mvc.Infrastructure.ValidationAttributes
{
    public class NoWhiteSpacesValidationAttribute : ValidationAttribute ////, IClientValidatable
    {
        public override bool IsValid(object value)
        {
            if (value is string textValue)
            {
                return !textValue.Contains(" ");
            }
            else
            {
                return false;
            }
        }
    }
}