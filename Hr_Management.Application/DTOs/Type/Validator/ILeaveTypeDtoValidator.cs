using FluentValidation;
using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hr_Management.Application.DTOs.Type.Validator
{
    public class ILeaveTypeDtoValidator : AbstractValidator<ILeaveTypeDto>
    {
        public ILeaveTypeDtoValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50)
                .WithMessage("{PropertyName} must not Maxed 50");

            RuleFor(p => p.DefauletDay)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .GreaterThan(0).WithMessage("{PropertyName} is more than 0.")
                .LessThan(100).WithMessage("{PropertyName} is less than 100.");

        }
    }
}
