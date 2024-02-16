using Hr_Management.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hr_Management.Application.DTOs.Type
{
    public class LeaveTypeDto : BaseDto , ILeaveTypeDto
    {

        public string Name { get; set; }
        public int DefauletDay { get; set; }

    }
}
