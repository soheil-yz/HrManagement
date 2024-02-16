using System;
using System.Collections.Generic;
using System.Text;

namespace Hr_Management.Application.DTOs.Allocation
{
    public interface ILeaveAllocationDto
    {
        public int NumberOfDay { get; set; }
        public int LeaveTypeId { get; set; }
        public int Priod {  get; set; }
    }
}
