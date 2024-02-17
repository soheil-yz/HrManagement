using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hr_Management.Application.Exceptions
{
    public class ValidationsException : ApplicationException
    {
        public List<string> Errors { get; set; } = new List<string>();

        public ValidationsException(ValidationResult validationResult)
        {
            foreach (var error in validationResult.Errors)
            {
                Errors.Add(error.ErrorMessage);
            }
        }
    }
}
