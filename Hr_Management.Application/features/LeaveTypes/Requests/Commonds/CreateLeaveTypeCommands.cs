using Hr_Management.Application.DTOs.Type;
using Hr_Management.Application.Responses;
using MediatR;

namespace Hr_Management.Application.features.LeaveTypes.Requests.Commonds
{
    public class CreateLeaveTypeCommands  : IRequest<BaseCommandResponse>
    {
        public CreateLeaveTypeDto LeaveTypeDto { get; set; }
    }
}
