using HrManagement.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagement
{
    public class LeaveRequest : BaseDomainEntity
    {
        public DateTime StartData { get; set; }
        public DateTime EndData { get; set; }
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public DateTime DateRequested { get; set; }
        public string RequestComments { get; set; }  
        public DateTime DateActioned { get; set; }
        public bool? Aoorived { get; set; }
        public bool Cancelled { get; set; }

            

    }
}
