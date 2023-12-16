using AutoMapper;
using Hr_Management.Application.DTOs;
using Hr_Management.Application.features.LeaveAllocation.Requests.Queries;
using Hr_Management.Application.features.LeaveTypes.Requests;
using Hr_Management.Application.features.LeaveTypes.Requests.Queries;
using Hr_Management.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hr_Management.Application.features.LeaveAllocation.Handlers.Queries
{
    public class GetLeaveRequestDetailRequestHandler : IRequestHandler<
        GetLeaveRequestDetailRequest, LeaveAllocationDto>

    {
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private readonly IMapper _mapper;

        public GetLeaveRequestDetailRequestHandler(ILeaveAllocationRepository leaveAllocationRepository, IMapper mapper)
        {
            _leaveAllocationRepository = leaveAllocationRepository;
            _mapper = mapper;
        }

        public async Task<LeaveAllocationDto> Handle(GetLeaveRequestDetailRequest request, CancellationToken cancellationToken)
        {
            var leaveAllocation = await _leaveAllocationRepository
                .GetLeaveAllocationWithDetails(request.Id);
            return _mapper.Map<LeaveAllocationDto>(leaveAllocation);     
        }
    }
}
