using Hr_Management.Application.DTOs.Request;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hr_Management.Application.features.LeaveRequests.Requests.Commonds
{
    public class UpdateLeaveRequestCommands : IRequest<Unit>
    {
        public LeaveRequestDto LeaveRequestDto { get; set; }
    }
}
