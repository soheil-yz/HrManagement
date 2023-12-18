using Hr_Management.Application.DTOs.Allocation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hr_Management.Application.features.LeaveAllocation.Requests.Queries
{
    public class GetLeaveRequestDetailRequest : IRequest<LeaveAllocationDto>
    {
        public int Id { get; set; } 
    }
}
