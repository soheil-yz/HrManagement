using FluentValidation;
using Hr_Management.Application.Contracts.Persistence;
using Hr_Management.Application.DTOs.Type;
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

            Include(new ILeaveRequestDtoValidator(_LeaveTypeRepository));

        }

            

    }
}
