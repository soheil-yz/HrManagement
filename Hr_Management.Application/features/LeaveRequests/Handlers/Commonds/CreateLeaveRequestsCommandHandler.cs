using AutoMapper;
using Hr_Management.Application.DTOs.Request.Validator;
using Hr_Management.Application.DTOs.Type.Validator;
using Hr_Management.Application.features.LeaveRequests.Requests.Commonds;
using Hr_Management.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Hr_Management.Application.features.LeaveRequests.Handlers.Commonds
{
    public class CreateLeaveRequestsCommandHandler : IRequestHandler<CreateLeaveRequestsCommand, int>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;
        public readonly ILeaveTypeRepository _LeaveTypeRepository;

        public CreateLeaveRequestsCommandHandler(ILeaveRequestRepository leaveRequestRepository , IMapper mapper,
            ILeaveTypeRepository leaveTypeRepository) 
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
            _LeaveTypeRepository = leaveTypeRepository;
        }


        public async Task<int> Handle(CreateLeaveRequestsCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateLeaveRequestDtoValidator(_LeaveTypeRepository);
            var validatorResult = await validator.ValidateAsync(request.LeaveRequestDto);

            if (validatorResult.IsValid == false)
                throw new Exception();
            var leaveRequest = _mapper.Map<Hr_Management.LeaveRequest>(request.LeaveRequestDto);
            leaveRequest = await _leaveRequestRepository.Add(leaveRequest);
            return leaveRequest.Id;
        }
    }
}
