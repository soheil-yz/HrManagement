using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hr_Management.Application.DTOs.Type.Validator
{
    public class UpdateLeaveTypeValidator: AbstractValidator<LeaveTypeDto>
    {
        public UpdateLeaveTypeValidator()
        {
            Include(new ILeaveTypeDtoValidator());

            RuleFor(p => p.Id)
                .NotEmpty()
                .WithMessage("{PropertyName} is required.");
        }
    }
}
