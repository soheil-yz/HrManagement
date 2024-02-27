using AutoMapper;
using Hr_Management.Application.Contracts.Persistence;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System;
using Hr_Management.Application.features.LeaveTypes.Requests.Queries;
using Hr_Management.Application.DTOs.Type;
using Hr_Management.Application.DTOs.Allocation;
using Hr_Management.Application.features.LeaveAllocation.Requests.Queries;

namespace Hr_Management.Application.features.LeaveTypes.Handlers.Queries
{
    public class GetLeaveAllocationListRequestHander :  
        IRequestHandler<GetLeaveAllocationListRequest, List<LeaveAllocationDto>>
    {
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private readonly IMapper _mapper;

        public GetLeaveAllocationListRequestHander(ILeaveAllocationRepository leaveAllocationRepository, IMapper mapper)
        {
            _leaveAllocationRepository = leaveAllocationRepository;
            _mapper = mapper;
        }
        public async Task<List<LeaveAllocationDto>> Handle(GetLeaveAllocationListRequest     request, CancellationToken cancellationToken)
        {
            var leaveAllocationList = await _leaveAllocationRepository.GetAll();
            return _mapper.Map<List<LeaveAllocationDto>>(leaveAllocationList);
        }
    }
}
