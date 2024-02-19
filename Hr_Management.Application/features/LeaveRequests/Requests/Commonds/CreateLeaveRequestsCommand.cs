using Hr_Management.Application.DTOs.Request;
using Hr_Management.Application.Responses;
using MediatR;

namespace Hr_Management.Application.features.LeaveRequests.Requests.Commonds
{
    public class CreateLeaveRequestsCommand : IRequest<BaseCommandResponse>
    {
        public CreateLeaveRequestDto LeaveRequestDto { get; set; }
    }
}
