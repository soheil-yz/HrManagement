﻿using Hr_Management.Application.DTOs.Common;
using System;

namespace Hr_Management.Application.DTOs.Request
{
    public class LeaveRequestDto : BaseDto
    {
        public DateTime StartData { get; set; }
        public DateTime EndData { get; set; }
        public LeaveTypeDto LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public DateTime DateRequested { get; set; }
        public string RequestComments { get; set; }
        public DateTime DateActioned { get; set; }
        public bool? Aoorived { get; set; }
        public bool Cancelled { get; set; }
    }
}
