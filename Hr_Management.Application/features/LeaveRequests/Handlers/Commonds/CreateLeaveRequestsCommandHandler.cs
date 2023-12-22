using AutoMapper;
using Hr_Management.Application.features.LeaveRequests.Requests.Commonds;
using Hr_Management.Application.Persistence.Contracts;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Hr_Management.Application.features.LeaveRequests.Handlers.Commonds
{
    public class CreateLeaveRequestsCommandHandler : IRequestHandler<CreateLeaveRequestsCommand, int>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;

        public CreateLeaveRequestsCommandHandler(ILeaveRequestRepository leaveRequestRepository , IMapper mapper) 
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateLeaveRequestsCommand request, CancellationToken cancellationToken)
        {
            var leaveRequest = _mapper.Map<Hr_Management.LeaveRequest>(request.LeaveRequestDto);
            leaveRequest = await _leaveRequestRepository.Add(leaveRequest);
            return leaveRequest.Id;
        }
    }
}
