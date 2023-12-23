using Hr_Management.Application.DTOs.Allocation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hr_Management.Application.features.LeaveAllcation.Requests.Commonds
{
    public class UpdateLeaveAllocationCommands : IRequest<Unit>
    {
        public LeaveAllocationDto LeaveAllocationDto { get; set; }
    }
}
