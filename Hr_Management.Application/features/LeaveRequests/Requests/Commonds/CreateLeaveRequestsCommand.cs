using Hr_Management.Application.DTOs.Request;
using MediatR;

namespace Hr_Management.Application.features.LeaveRequests.Requests.Commonds
{
    public class CreateLeaveRequestsCommand : IRequest<int>
    {
        public LeaveRequestDto LeaveRequestDto { get; set; }
    }
}
