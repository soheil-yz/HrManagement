using System;
using System.Collections.Generic;
using System.Text;

namespace Hr_Management.Application.DTOs.Request
{
    public class UpdateLeaveRequestDto
    {   
        public DateTime StartData { get; set; }
        public DateTime EndData { get; set; }
        public int LeaveTypeId { get; set; }
        public string RequestComments { get; set; }
        public bool Cancelled { get; set; }

    }
}
