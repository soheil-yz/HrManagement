using FluentValidation;
using Hr_Management.Application.DTOs.Type;
using Hr_Management.Application.Persistence.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hr_Management.Application.DTOs.Request.Validator
{
    public class CreateLeaveRequestDtoValidator : AbstractValidator<CreateLeaveRequestDto>
    {
        private readonly ILeaveTypeRepository _LeaveTypeRepository;
        public CreateLeaveRequestDtoValidator(ILeaveTypeRepository leaveTypeRepository)
        {
            _LeaveTypeRepository = leaveTypeRepository;

            RuleFor(p => p.StartDate).LessThan(p => p.EndDate)
                .WithMessage("{PropertyName} must less than {ComparisonValue}");
            RuleFor(p => p.EndDate)
                .GreaterThan(p => p.StartDate)
                .WithMessage("{PropertyName} must more than {ComparisonValue}");
            RuleFor(p => p.LeaveTypeId)
                .GreaterThan(0)
                .MustAsync(async (id, token) =>
                {
                    var leaveTypeExist = await _LeaveTypeRepository.Exist(id);
                    return !leaveTypeExist;
                })
                .WithMessage("{PropertyName} does not exist");
            LeaveTypeRepository = leaveTypeRepository;
        }

        public ILeaveTypeRepository LeaveTypeRepository { get; }
    }
}
