using Hr_Management.Application.DTOs.Request;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hr_Management.Application.features.LeaveRequests.Requests.Commonds
{
    public class UpdateLeaveRequestCommands : IRequest<Unit>
    {
        public int Id { get; set; }
        public UpdateLeaveRequestDto LeaveRequestDto { get; set; }
        public ChangeLeaveRequestApprovealDto ChangeLeaveRequestApprovealDto { get; set; }
    }
}
