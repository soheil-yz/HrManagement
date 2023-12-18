using Hr_Management.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hr_Management.Application.DTOs.Type
{
    public class LeaveTypeDto : BaseDto
    {
        public string Name { get; set; }
        public int DefaultDay { get; set; }
    }
}
