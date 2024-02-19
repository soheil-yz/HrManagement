using AutoMapper;
using Hr_Management.Application.DTOs.Allocation.Validator;
using Hr_Management.Application.DTOs.Request.Validator;
using Hr_Management.Application.Exceptions;
using Hr_Management.Application.features.LeaveAllocation.Requests.Commonds;
using Hr_Management.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Transactions;

namespace Hr_Management.Application.features.LeaveAllocation.Handlers.Commonds
{
    public class CreateLeaveAllocationsCommandHandler : IRequestHandler<CreateLeaveAllocationsCommands, int>
    {
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private readonly IMapper _mapper;
        private readonly ILeaveTypeRepository _LeaveTypeRepository;

        public CreateLeaveAllocationsCommandHandler(ILeaveAllocationRepository leaveAllocationRepository , IMapper mapper, ILeaveTypeRepository leaveTypeRepository)
        {
            _leaveAllocationRepository = leaveAllocationRepository;
            _mapper = mapper;
            _LeaveTypeRepository = leaveTypeRepository;
        }
        public async Task<int> Handle(CreateLeaveAllocationsCommands request, CancellationToken cancellationToken)
        {
            var validator = new CreateLeaveAllocationDtoValidator(_LeaveTypeRepository);
            var validatorResult = await validator.ValidateAsync(request.LeaveAllocationDto);

            if (validatorResult.IsValid == false)
                throw new ValidationsException(validatorResult);

            var leaveAllocations = _mapper.Map<Hr_Management.LeaveAllocation>(request.LeaveAllocationDto);
            leaveAllocations = await _leaveAllocationRepository.Add(leaveAllocations);
            return leaveAllocations.Id;
        }
    }
}
