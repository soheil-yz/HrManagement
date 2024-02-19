using AutoMapper;
using Hr_Management.Application.DTOs;
using Hr_Management.Application.DTOs.Request;
using Hr_Management.Application.features.LeaveRequest.Requests.Queries;
using Hr_Management.Application.features.LeaveTypes.Requests;
using Hr_Management.Application.features.LeaveTypes.Requests.Queries;
using Hr_Management.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hr_Management.Application.features.LeaveRequest.Handlers.Queries
{
    public class GetLeaveRequestDetailRequestHandler : IRequestHandler<
        GetLeaveRequestDetailRequest, LeaveRequestDto>

    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;

        public GetLeaveRequestDetailRequestHandler(ILeaveRequestRepository leaveRequestRepository, IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
        }

        public async Task<LeaveRequestDto> Handle(GetLeaveRequestDetailRequest request, CancellationToken cancellationToken)
        {
            var leaveRequest = await _leaveRequestRepository
                .GetLeaveRequestWithDetails(request.Id);
            return _mapper.Map<LeaveRequestDto>(leaveRequest);     
        }
    }
}
