using Hr_Management.Application.DTOs.Type;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hr_Management.Application.features.LeaveTypes.Requests.Queries
{
    public class GetLeaveTypeDetailRequest : IRequest<LeaveTypeDto>
    {
        public int Id { get; set; } 
    }
}
