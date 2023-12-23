using AutoMapper;
using Hr_Management.Application.features.LeaveRequests.Requests.Commonds;
using Hr_Management.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hr_Management.Application.features.LeaveRequests.Handlers.Commonds
{
    public class UpdateLeaveRequestCommandHandler : IRequestHandler<UpdateLeaveRequestCommands, Unit>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;

        public UpdateLeaveRequestCommandHandler(ILeaveRequestRepository leaveRequestRepository, IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateLeaveRequestCommands request, CancellationToken cancellationToken)
        {
            var leaveRequest = await _leaveRequestRepository.Get(request.LeaveRequestDto.Id);
            _mapper.Map(request.LeaveRequestDto, leaveRequest);
            await _leaveRequestRepository.Update(leaveRequest);
            return Unit.Value;
        }
    }
}
