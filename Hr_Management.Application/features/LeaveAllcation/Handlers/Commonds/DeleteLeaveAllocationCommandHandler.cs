using AutoMapper;
using Hr_Management.Application.Exceptions;
using Hr_Management.Application.features.LeaveAllcation.Requests.Commonds;
using Hr_Management.Application.features.LeaveRequests.Requests.Commonds;
using Hr_Management.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hr_Management.Application.features.LeaveAllcation.Handlers.Commonds
{
    internal class DeleteLeaveAllocationCommandHandler : IRequestHandler<DeleteLeaveAllocationCommands , Unit>
    {
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private readonly IMapper _mapper;

        public DeleteLeaveAllocationCommandHandler(ILeaveAllocationRepository leaveAllocationRepository, IMapper mapper)
        {
            _leaveAllocationRepository = leaveAllocationRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(DeleteLeaveAllocationCommands request, CancellationToken cancellationToken)
        {
            var leaveAllocation = await _leaveAllocationRepository.Get(request.Id);

            if (leaveAllocation == null)
                throw new NotFoundException(nameof(), request.Id);
            await _leaveAllocationRepository.Delete(leaveAllocation);
            return Unit.Value;
        }
    }
}
