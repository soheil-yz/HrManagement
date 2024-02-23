using Hr_Management.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hr_Management.Application.DTOs.Request
{
    public class UpdateLeaveRequestDto :BaseDto,ILeaveRequestDto
    {   
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int LeaveTypeId { get; set; }
        public string RequestComments { get; set; }
        public bool Cancelled { get; set; }

        public static implicit operator UpdateLeaveRequestDto(LeaveRequestDto v)
        {
            throw new NotImplementedException();
        }
    }
}
