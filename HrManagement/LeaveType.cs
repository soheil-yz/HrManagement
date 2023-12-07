using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagement
{
    public class LeaveType
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public int DefaultDay { get; set; }
        public DateTime DateTime { get; set; }
    }
}
