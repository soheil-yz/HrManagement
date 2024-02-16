﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Hr_Management.Application.DTOs.Request
{
    public interface ILeaveRequestDto
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int LeaveTypeId { get; set; }

    }
}
