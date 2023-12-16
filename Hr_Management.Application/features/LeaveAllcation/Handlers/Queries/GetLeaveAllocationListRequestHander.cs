using AutoMapper;
using Hr_Management.Application.DTOs;
using Hr_Management.Application.Persistence.Contracts;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System;
using Hr_Management.Application.features.LeaveTypes.Requests.Queries;

namespace Hr_Management.Application.features.LeaveTypes.Handlers.Queries
{
    public class GetLeaveRequestListRequestHander :  
        IRequestHandler<GetLeaveTypeListRequest, List<LeaveTypeDto>>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        public GetLeaveRequestListRequestHander(ILeaveTypeRepository leaveTypeRepository,IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }
        public async Task<List<LeaveTypeDto>> Handle(GetLeaveTypeListRequest request, CancellationToken cancellationToken)
        {
            var leaveTypeList = await _leaveTypeRepository.GetAll();
            return _mapper.Map<List<LeaveTypeDto>>(leaveTypeList);
        }
    }
}
