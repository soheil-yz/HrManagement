using Hr_Management.Common;
using System;

namespace Hr_Management
{
    public class LeaveRequest : BaseDomainEntity
    {
        public DateTime StartData { get; set; }
        public DateTime EndData { get; set; }
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public DateTime DateRequested { get; set; }
        public string RequestComments { get; set; }  
        public DateTime? DateActioned { get; set; }
        public bool? Aoorived { get; set; }
        public bool Cancelled { get; set; }

    }
}
