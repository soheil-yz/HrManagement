using Hr_Management.Application.DTOs.Type;
using MediatR;

namespace Hr_Management.Application.features.LeaveTypes.Requests.Commonds
{
    public class CreateLeaveTypeCommands  : IRequest<int>
    {
        public CreateLeaveTypeDto LeaveTypeDto { get; set; }
    }
}
