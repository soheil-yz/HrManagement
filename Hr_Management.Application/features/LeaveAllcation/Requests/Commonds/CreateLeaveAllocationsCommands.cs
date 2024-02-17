using Hr_Management.Application.DTOs.Allocation;
using Hr_Management.Application.DTOs.Request;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hr_Management.Application.features.LeaveAllocation.Requests.Commonds
{
    public class CreateLeaveAllocationsCommands : IRequest<int>
    {
        public CreateLeaveAllocationDto LeaveAllocationDto { get; set; }

    }
}
