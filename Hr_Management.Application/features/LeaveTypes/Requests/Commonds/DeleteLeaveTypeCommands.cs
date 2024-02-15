using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hr_Management.Application.features.LeaveTypes.Requests.Commonds
{
    public class DeleteLeaveTypeCommands :IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
