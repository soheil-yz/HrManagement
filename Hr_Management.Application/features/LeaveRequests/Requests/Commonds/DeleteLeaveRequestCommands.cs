using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hr_Management.Application.features.LeaveRequests.Requests.Commonds
{
    public class DeleteLeaveRequestCommands : IRequest<Unit>
    {
        public int Id { get; set; } 
    }
}
