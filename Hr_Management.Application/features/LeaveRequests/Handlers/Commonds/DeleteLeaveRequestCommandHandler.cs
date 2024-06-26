﻿using AutoMapper;
using Hr_Management.Application.DTOs.Request;
using Hr_Management.Application.Exceptions;
using Hr_Management.Application.features.LeaveRequests.Requests.Commonds;
using Hr_Management.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Hr_Management;
namespace Hr_Management.Application.features.LeaveRequests.Handlers.Commonds
{
    internal class DeleteLeaveRequestCommandHandler : IRequestHandler<DeleteLeaveRequestCommands , Unit>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;

        public DeleteLeaveRequestCommandHandler(ILeaveRequestRepository leaveRequestRepository, IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(DeleteLeaveRequestCommands request, CancellationToken cancellationToken)
        {
            var leaveRequest = await _leaveRequestRepository.Get(request.Id);

            if (leaveRequest == null)
                throw new NotFoundException(nameof(LeaveRequest), request.Id);
            await _leaveRequestRepository.Delete(leaveRequest);
            return Unit.Value;
        }


    }
}