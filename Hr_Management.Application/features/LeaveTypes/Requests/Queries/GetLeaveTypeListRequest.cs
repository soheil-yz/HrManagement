using Hr_Management.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hr_Management.Application.features.LeaveTypes.Requests.Queries
{
    public class GetLeaveTypeListRequest : IRequest<List<LeaveTypeDto>>
    {

    }
}
