using Hr_Management.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hr_Management.Application.DTOs.Request
{
    public class CreateLeaveRequestDto : BaseDto
    {
        public DateTime StartData { get; set; }
        public DateTime EndData { get; set; }
        public int LeaveTypeId { get; set; }
        public DateTime DateRequested { get; set; }
        public string RequestCommonts { get; set; }


    }
}
