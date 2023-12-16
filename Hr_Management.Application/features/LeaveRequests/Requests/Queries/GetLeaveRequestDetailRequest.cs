using Hr_Management.Application.DTOs;
using Hr_Management.Application.DTOs.Request;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hr_Management.Application.features.LeaveRequest.Requests.Queries
{
    public class GetLeaveRequestDetailRequest : IRequest<LeaveRequestDto>
    {
        public int Id { get; set; } 
    }
}
