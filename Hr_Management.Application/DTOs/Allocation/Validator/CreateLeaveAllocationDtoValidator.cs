using FluentValidation;
using Hr_Management.Application.Contracts.Persistence;
using Hr_Management.Application.DTOs.Type;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hr_Management.Application.DTOs.Allocation.Validator
{
    public class CreateLeaveAllocationDtoValidator : AbstractValidator<CreateLeaveAllocationDto>
    {
        public readonly ILeaveTypeRepository _LeaveTypeRepository;
        public CreateLeaveAllocationDtoValidator(ILeaveTypeRepository leaveTypeRepository)
        {
            _LeaveTypeRepository = leaveTypeRepository;

            Include(new ILeaveAllocationValidator(_LeaveTypeRepository));
        }
    }
}
