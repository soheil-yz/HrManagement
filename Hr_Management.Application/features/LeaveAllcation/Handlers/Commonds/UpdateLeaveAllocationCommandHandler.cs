using AutoMapper;
using Hr_Management.Application.features.LeaveAllcation.Requests.Commonds;
using Hr_Management.Application.features.LeaveTypes.Requests.Commonds;
using Hr_Management.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hr_Management.Application.features.LeaveAllcation.Handlers.Commonds
{
    public class UpdateLeaveAllocationCommandHandler : IRequestHandler<UpdateLeaveAllocationCommands, Unit>
    {
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private readonly IMapper _mapper;

        public UpdateLeaveAllocationCommandHandler(ILeaveAllocationRepository leaveAllocationRepository, IMapper mapper)
        {
            _leaveAllocationRepository = leaveAllocationRepository;
            _mapper = mapper;
        }
        public Task<Unit> Handle(UpdateLeaveAllocationCommands request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
