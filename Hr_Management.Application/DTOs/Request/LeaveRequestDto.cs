using Hr_Management.Application.DTOs.Common;
using Hr_Management.Application.DTOs.Type;
using System;

namespace Hr_Management.Application.DTOs.Request
{
    public class LeaveRequestDto : BaseDto , ILeaveRequestDto
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int LeaveTypeId { get; set; }
        public LeaveTypeDto LeaveType { get; set; }
        public DateTime DateRequested { get; set; }
        public string RequestComments { get; set; }
        public DateTime DateActioned { get; set; }
        public bool? Aoorived { get; set; }
        public bool Cancelled { get; set; }
    }
}
