using AutoMapper;
using Hr_Management.Application.Exceptions;
using Hr_Management.Application.features.LeaveTypes.Requests.Commonds;
using Hr_Management.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hr_Management.Application.features.LeaveTypes.Handlers.Commonds
{
    public class DeleteLeaveTypeCommandHandler : IRequestHandler<DeleteLeaveTypeCommands , Unit>
    {
        private readonly ILeaveTypeRepository _LeaveTypeRepository;
        private readonly IMapper _mapper;

        public DeleteLeaveTypeCommandHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            _LeaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(DeleteLeaveTypeCommands request, CancellationToken cancellationToken)
        {
            var leaveType = await _LeaveTypeRepository.Get(request.Id);
            if (leaveType == null) 
                throw new NotFoundException(nameof(LeaveType),request.Id);

            await _LeaveTypeRepository.Delete(leaveType);
            return Unit.Value;
        }
       
    }
}
