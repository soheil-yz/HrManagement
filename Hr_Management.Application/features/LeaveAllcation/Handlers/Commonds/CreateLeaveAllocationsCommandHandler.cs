using AutoMapper;
using Hr_Management.Application.features.LeaveAllocation.Requests.Commonds;
using Hr_Management.Application.Persistence.Contracts;
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

        public CreateLeaveAllocationsCommandHandler(ILeaveAllocationRepository leaveAllocationRepository , IMapper mapper)
        {
            _leaveAllocationRepository = leaveAllocationRepository;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateLeaveAllocationsCommands request, CancellationToken cancellationToken)
        {
              var leaveAllocations = _mapper.Map<Hr_Management.LeaveAllocation>(request.LeaveAllocationDto);
            leaveAllocations = await _leaveAllocationRepository.Add(leaveAllocations);
            return leaveAllocations.Id;
        }
    }
}
