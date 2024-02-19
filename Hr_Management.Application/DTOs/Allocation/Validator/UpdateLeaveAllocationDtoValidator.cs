using FluentValidation;
using Hr_Management.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hr_Management.Application.DTOs.Allocation.Validator
{
    public class UpdateLeaveAllocationDtoValidator : AbstractValidator<UpdateLeaveAllocationDto>
    {
        public readonly ILeaveTypeRepository _LeaveTypeRepository;
        public UpdateLeaveAllocationDtoValidator(ILeaveTypeRepository leaveTypeRepository)
        {
            _LeaveTypeRepository = leaveTypeRepository;

            Include(new ILeaveAllocationValidator(_LeaveTypeRepository));

            RuleFor(p => p.Id).NotNull().WithMessage("{PropertyName} is required .");
        }
    }
}
