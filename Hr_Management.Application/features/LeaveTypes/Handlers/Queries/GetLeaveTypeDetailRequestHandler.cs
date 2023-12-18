using AutoMapper;
using Hr_Management.Application.DTOs.Type;
using Hr_Management.Application.features.LeaveTypes.Requests;
using Hr_Management.Application.features.LeaveTypes.Requests.Queries;
using Hr_Management.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hr_Management.Application.features.LeaveTypes.Handlers.Queries
{
    public class GetLeaveTypeDetailRequestHandler :IRequestHandler<
        GetLeaveTypeDetailRequest, LeaveTypeDto>

    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        public GetLeaveTypeDetailRequestHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }

        public async Task<LeaveTypeDto> Handle(GetLeaveTypeDetailRequest request, CancellationToken cancellationToken)
        {
            var laeveType = await _leaveTypeRepository.Get(request.Id);
            return _mapper.Map<LeaveTypeDto>(laeveType);
        }
    }
}
