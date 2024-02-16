using FluentValidation;
using Hr_Management.Application.Persistence.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hr_Management.Application.DTOs.Allocation.Validator
{
    public class ILeaveAllocationValidator : AbstractValidator<ILeaveAllocationDto>
    {
        public readonly ILeaveTypeRepository _LeaveTypeRepository;
        public ILeaveAllocationValidator(ILeaveTypeRepository leaveTypeRepository)
        {
            _LeaveTypeRepository = leaveTypeRepository;

            RuleFor(p => p.NumberOfDay)
                .GreaterThan(0)
                .WithMessage("{PropertyName} must greater than {ComparisonValue}");
            RuleFor(p => p.Priod)
                .GreaterThanOrEqualTo(DateTime.Now.Year)
                .WithMessage("{PropertyName} must greater than {ComparisonValue}");

            RuleFor(p => p.LeaveTypeId)
                .GreaterThan(0)
                .MustAsync(async (id, token) =>
                    {
                        var leaveTypeExist = await _LeaveTypeRepository.Exist(id);
                        return !leaveTypeExist;
                    })
                .WithMessage("{PropertyName} does not exist");
        }

    }
}