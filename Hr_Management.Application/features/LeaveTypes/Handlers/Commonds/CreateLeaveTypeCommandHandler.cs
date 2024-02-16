using AutoMapper;
using FluentValidation;
using Hr_Management.Application.DTOs.Type.Validator;
using Hr_Management.Application.features.LeaveTypes.Requests.Commonds;
using Hr_Management.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Hr_Management.Application.features.LeaveTypes.Handlers.Commonds
{
    public class CreateLeaveTypeCommandHandler : IRequestHandler<CreateLeaveTypeCommands, int>
    {
        private readonly ILeaveTypeRepository _LeaveTypeRepository;
        private readonly IMapper _mapper;

        public CreateLeaveTypeCommandHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            _LeaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateLeaveTypeCommands request, CancellationToken cancellationToken)
        {
            var validator = new ILeaveTypeDtoValidator();
            var validatorResult = await validator.ValidateAsync(request.LeaveTypeDto);

            if (validatorResult.IsValid == false)
                 throw new Exception();

            var leaveType = _mapper.Map<LeaveType>(request.LeaveTypeDto);
            leaveType = await _LeaveTypeRepository.Add(leaveType);
            return leaveType.Id;
        }
    }
}
