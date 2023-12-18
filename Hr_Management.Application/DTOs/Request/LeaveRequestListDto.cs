using Hr_Management.Application.DTOs.Common;
using Hr_Management.Application.DTOs.Type;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hr_Management.Application.DTOs.Request
{
    public class LeaveRequestListDto : BaseDto
    {
        public LeaveTypeDto LeaveType { get; set; }
        public DateTime DateRequested { get; set; }
        public bool? Aoorived { get; set; }

    }
}
