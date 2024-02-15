using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hr_Management.Application.features.LeaveAllcation.Requests.Commonds
{
    public class DeleteLeaveAllocationCommands : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
