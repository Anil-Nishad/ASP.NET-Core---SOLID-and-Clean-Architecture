using System.ComponentModel.DataAnnotations;

namespace HR.LeaveManagement.Application.Exceptions;

public class BadRequestException : Exception
{
    public BadRequestException(string message) : base(message)
    {

    }

    //public BadRequestException(string message, FluentValidation.Results.ValidationResult validationResult) : this(message)
    //{
    //}

    //public BadRequestException(string message, FluentValidation.Results.ValidationResult validationResult) : base(message)
    //{
    //    ValidationErrors = new();
    //    foreach (var error in validationResult.Errors)
    //    {
    //        ValidationErrors.Add(error.ErrorMessage);
    //    }
    //}

    //public List<string> ValidationErrors { get; set; }
    public BadRequestException(string message, FluentValidation.Results.ValidationResult validationResult) : base(message)
    {
        ValidationErrors = validationResult.ToDictionary();
    }
    public IDictionary<string, string[]> ValidationErrors { get; set; }
}
