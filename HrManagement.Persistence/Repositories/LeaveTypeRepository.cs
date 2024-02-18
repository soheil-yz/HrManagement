using Hr_Management;
using Hr_Management.Application.Persistence.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace HrManagement.Persistence.Repositories
{
    public class LeaveTypeRepository :  GenericRepository<LeaveType> ,ILeaveTypeRepository
    {
        private readonly LeaveManagementDbContext _context;
        public LeaveTypeRepository(LeaveManagementDbContext context) : base(context) 
        {
            _context = context;
        }
    }
}
