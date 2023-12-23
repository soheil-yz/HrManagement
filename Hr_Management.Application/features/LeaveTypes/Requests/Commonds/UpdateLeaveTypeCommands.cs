using Hr_Management.Application.DTOs.Type;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hr_Management.Application.features.LeaveTypes.Requests.Commonds
{
    public class UpdateLeaveTypeCommands : IRequest<Unit>
    {
        public LeaveTypeDto LeaveTypeDto { get; set; } 
    }
}
