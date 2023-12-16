using AutoMapper;
using Hr_Management.Application.DTOs;
using Hr_Management.Application.Persistence.Contracts;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System;
using Hr_Management.Application.features.LeaveTypes.Requests.Queries;
using Hr_Management.Application.DTOs.Request;
using Hr_Management.Application.features.LeaveRequest.Requests.Queries;

namespace Hr_Management.Application.features.LeaveRequest.Handlers.Queries
{
    public class GetLeaveRequestListRequestHander :  
        IRequestHandler<GetLeaveRequestListRequest, List<LeaveRequestListDto>>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;

        public GetLeaveRequestListRequestHander(ILeaveRequestRepository leaveRequestRepository, IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
        }
        public async Task<List<LeaveRequestListDto>> Handle(GetLeaveRequestListRequest request, CancellationToken cancellationToken)
        {
            var leaveRequestList = await _leaveRequestRepository.GetLeaveRequestsWithDetails();
            return _mapper.Map<List<LeaveRequestListDto>>(leaveRequestList);
        }
    }
}
