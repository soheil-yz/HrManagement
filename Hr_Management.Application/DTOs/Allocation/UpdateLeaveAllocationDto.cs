﻿using Hr_Management.Application.DTOs.Common;
using Hr_Management.Application.DTOs.Type;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hr_Management.Application.DTOs.Allocation
{
    public class UpdateLeaveAllocationDto : BaseDto ,  ILeaveAllocationDto
    {
        public int NumberOfDay { get; set; }
        public int LeaveTypeId { get; set; }
        public int Priod { get; set; }
    }
}
