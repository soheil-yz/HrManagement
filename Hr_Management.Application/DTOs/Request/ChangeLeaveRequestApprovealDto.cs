using Hr_Management.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hr_Management.Application.DTOs.Request
{
    public class ChangeLeaveRequestApprovealDto : BaseDto
    {
        public bool? Aoorived { get; set; }
    }
}
